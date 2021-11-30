using System;
using System.Collections.Generic;
using TicTacToeCore.ExtensionMethods;

namespace TicTacToeCore.Models
{
    public class GameStateModel : IEquatable<GameStateModel>
    {
        public Name Turn { get; set; } = Name.X;
        public HashSet<PieceModel> Pieces { get; set; } = new HashSet<PieceModel>();

        // Implementation for IEquatable
        public bool Equals(GameStateModel other)
        {
            if (other == null)
            {
                return false;
            }
            if (Pieces.Count != other.Pieces.Count)
            {
                return false;
            }
            return Pieces.Overlaps(other.Pieces);
        }

        // Custom HashCode for this class
        public override int GetHashCode()
        {
            Console.WriteLine("GetHash");

            return -1373353550 + EqualityComparer<HashSet<PieceModel>>.Default.GetHashCode(Pieces);
        }

        // DeepClone for GameStateModel
        public GameStateModel DeepClone()
        {
            var output = new GameStateModel
            {
                Pieces = Pieces.DeepClone(),
                Turn = Turn
            };

            return output;
        }
    }
}
