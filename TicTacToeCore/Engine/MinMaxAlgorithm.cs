using System;
using System.Collections.Generic;
using TicTacToeCore.Models;

namespace TicTacToeCore.Engine
{
    public class MinMaxAlgorithm : IEngine
    {
        private byte Low { get; } = 0;
        private byte High { get; } = 255;
        private byte Depth { get; set; }
        private GameStateModel OriginalState { get; set; }
        
        private GameStateModel[] GetStatesToEvaluate(GameStateModel state, PositionModel[] legalMoves) 
        {
            var output = new GameStateModel[legalMoves.Length];

            for (int i = 0; i < legalMoves.Length; i++)
            {
                var nextState = state.DeepClone();

                nextState.MakeMove(legalMoves[i]);

                output[i] = nextState;
            }

            return output;
        }
        private byte[] GetValueOfMoves(GameStateModel[] gameStates) 
        {
            var output = new byte[gameStates.Length];

            for (int i = 0; i < gameStates.Length; i++)
            {
                var node = new Node(gameStates[i]);

                output[i] = MinMax(node, node.State.Turn == Name.X, Low, High,1);
            }

            return output;
        }
        private List<PositionModel> GetBestMoves(PositionModel[] legalMoves, byte[] valueOfMoves , bool MaxPlayer) 
        {
            var output = new List<PositionModel>();

            if (MaxPlayer)                 
            {
                byte best = Low;

                for (int i = 0; i < valueOfMoves.Length; i++)
                {
                    best = Math.Max(best, valueOfMoves[i]);
                }

                for (int i = 0; i < valueOfMoves.Length; i++)
                {
                    if (valueOfMoves[i] == best)
                    {
                        output.Add(legalMoves[i]);
                    }
                }
            }
            else                                         
            {
                byte best = High;

                for (int i = 0; i < valueOfMoves.Length; i++)
                {
                    best = Math.Min(best, valueOfMoves[i]);
                }
                for (int i = 0; i < valueOfMoves.Length; i++)
                {
                    if (valueOfMoves[i] == best)
                    {
                        output.Add(legalMoves[i]);
                    }
                }
            }

            return output;
        }
        private PositionModel GetMoveRandomly(List<PositionModel> bestMoves) 
        {
            if (bestMoves.Count == 0)
            {
                throw new InvalidOperationException("No legal moves");
            }

            var rng = new Random();
            int randomIndex = rng.Next(0, bestMoves.Count - 1);

            return bestMoves[randomIndex];
        }
        private byte EvaluateState(GameStateModel state , byte depth)
        {
            if (state.Winner() == Name.X)
            {
                return (byte)(200 - depth);
            }
            else if (state.Winner() == Name.O)
            {
                return (byte)(100 + depth);
            }
            else if (OriginalState.Turn == Name.X)
            {
                return (byte)(150 + depth);
            }
            else
            {
                return (byte)(150 - depth);
            }

        }
        private byte MinMax(Node node, bool isMax, byte alpha, byte beta, byte depth)
        {
            if (node.State.GameIsFinished() || depth == Depth)
            {
                return EvaluateState(node.State , depth);
            }

            depth++;

            if (isMax)
            {
                var best = Low;
                node.GetChildren();

                foreach (var child in node.Children)
                {
                    var childValue = MinMax(child, false, alpha, beta, depth);
                    best = Math.Max(best, childValue);
                    alpha = Math.Max(alpha, best);
                    if (alpha >= beta) { break; }
                }
                return best;
            }
            else
            {
                var best = High;
                node.GetChildren();

                foreach (var child in node.Children)
                {
                    var childValue = MinMax(child, true, alpha, beta, depth);
                    best = Math.Min(best, childValue);
                    beta = Math.Min(beta, best);
                    if (alpha >= beta) { break; }
                }
                return best;
            }

        }

        private class Node
        {
            public Node(GameStateModel state)
            {
                State = state.DeepClone();
            }
            public GameStateModel State { get; set; } = new GameStateModel();
            public List<Node> Children { get; set; }
            public void GetChildren()
            {
                Children = new List<Node>();

                var positionList = State.GetLegalMoves();

                foreach (var p in positionList)
                {
                    var child = new Node(State);
                    child.State.MakeMove(p);
                    Children.Add(child);
                }
            }
        }
        
        private PositionModel GetNextMoveLogic(GameStateModel state)
        {
            OriginalState = state.DeepClone();

            PositionModel[] legalMoves = state.GetLegalMoves().ToArray();

            GameStateModel[] statesToEvaluate = GetStatesToEvaluate(state, legalMoves);

            byte[] valueOfMoves = GetValueOfMoves(statesToEvaluate);

            List<PositionModel> bestMoves = GetBestMoves(legalMoves, valueOfMoves, state.Turn == Name.X);

            return GetMoveRandomly(bestMoves);
        }
        public PositionModel GetNextMove_Max(GameStateModel state)
        {
            Depth = High;
            return GetNextMoveLogic(state);
        }
        
        public PositionModel GetNextMove_SelectDepth(GameStateModel state, int depth) 
        {
            if (depth > 9)
            {
                Depth = 9;
            }
            else if (depth < 1)
            {
                Depth = 1;
            }
            else
            {
                Depth = (byte)depth;
            }

            return GetNextMoveLogic(state);
        }
        
    }
}
