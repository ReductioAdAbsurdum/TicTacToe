using System.Collections.Generic;
using TicTacToeCore.Models;

namespace TicTacToeCore
{
    public static class GameLogic
    {
        public static bool MakeMove(this GameStateModel state, PositionModel position) 
        {
            if (!state.PieceAtPosition(position))
            {
                if (state.Turn == Name.X)
                {
                    state.Pieces.Add(new PieceModel(position, Name.X));
                }
                else 
                {
                    state.Pieces.Add(new PieceModel(position, Name.O));
                }
                state.ChangeTurn();
            }

            return false;
        }  
        public static List<PositionModel> GetLegalMoves(this GameStateModel state) 
        {
            var output = new List<PositionModel>();

            for (byte i = 1; i <= 3; i++)
            {
                for (byte j = 1; j <= 3; j++)
                {
                    var p = new PositionModel(i, j);
                    
                    if (!state.PieceAtPosition(p))
                    {
                        output.Add(p);
                    }
                }
            }

            return output;      
        } 
        public static bool GameIsFinished(this GameStateModel state)
        {
            if (state.Pieces.Count == 9)
            {
                return true;
            }
            if (state.Winner() != Name.None)
            {
                return true;
            }           

            return false;
        }
        public static Name Winner(this GameStateModel state) 
        {
            // Line Check
            bool xH = true;
            bool oH = true;
            bool xV = true;
            bool oV = true;

            for (byte i = 1; i <= 3; i++)
            {
                for (byte j = 1; j <= 3; j++)
                {
                    xH = xH && state.X_AtPosition(new PositionModel(j, i));
                    oH = oH && state.O_AtPosition(new PositionModel(j, i));
                    
                    xV = xV && state.X_AtPosition(new PositionModel(i, j));
                    oV = oV && state.O_AtPosition(new PositionModel(i, j));

                }
                if (xH || xV)
                {
                    return Name.X;
                }
                if (oH || oV)
                {
                    return Name.O;
                }
                xH = true;
                xV = true;
                oH = true;
                oV = true;
            }

            // Check Diagonals
            bool d1X = true;
            bool d1O = true;
            bool d2X = true;
            bool d2O = true;

            for (byte i = 1; i <= 3; i++)
            {
                d1X = d1X && state.X_AtPosition(new PositionModel(i, i));
                d1O = d1O && state.O_AtPosition(new PositionModel(i, i));

                d2X = d2X && state.X_AtPosition(new PositionModel(i, (byte)(4 - i)));
                d2O = d2O && state.O_AtPosition(new PositionModel(i, (byte)(4 - i)));
            }
            if (d1X || d2X)
            {
                return Name.X;
            }
            if (d1O || d2O)
            {
                return Name.O;
            }

            // If no winner return None
            return Name.None;
        }
        
        private static void ChangeTurn(this GameStateModel state) 
        {
            if (state.Turn == Name.X)
            {
                state.Turn = Name.O;
            }
            else 
            {
                state.Turn = Name.X;
            }
        }
        private static bool X_AtPosition(this GameStateModel state, PositionModel position) 
        {
            if (state.Pieces.Contains(new PieceModel(position, Name.X))) 
            {
                return true; 
            }

            return false;
        }
        private static bool O_AtPosition(this GameStateModel state, PositionModel position)
        {
            if (state.Pieces.Contains(new PieceModel(position, Name.O)))
            {
                return true;
            }

            return false;
        }
        private static bool PieceAtPosition(this GameStateModel state, PositionModel position) 
        {
            return state.X_AtPosition(position) || state.O_AtPosition(position);
        }
    }
}
