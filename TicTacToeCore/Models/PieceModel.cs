using System;

namespace TicTacToeCore.Models
{
    public struct PieceModel : IEquatable<PieceModel>
    {
        public PieceModel(PositionModel position, Name piece)
        {
            Position = position;
            PieceName = piece;
        }
        public PositionModel Position { get; }
        public Name PieceName { get; }

        // Implementation for IEquatable
        public bool Equals(PieceModel other)
        {
            return Position.Equals(other.Position) &&
                   PieceName == other.PieceName;
        }

        // Custom HashCode for this struct
        public override int GetHashCode()
        {
            int hashCode = -2057428512;
            hashCode = hashCode * -1521134295 + Position.GetHashCode();
            hashCode = hashCode * -1521134295 + PieceName.GetHashCode();
            return hashCode;
        }
    }
}
