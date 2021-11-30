using System;
using System.Collections.Generic;

namespace TicTacToeCore.Models
{
    public struct PositionModel : IEquatable<PositionModel>
    {
        public PositionModel(byte file, byte rank)
        {
            File = file;
            Rank = rank;
        }
        
        public byte File { get; }
        public byte Rank { get; }

        // Implementation for IEquatable
        public bool Equals(PositionModel other)
        {
            return File == other.File &&
                   Rank == other.Rank;
        }

        // Custom HashCode for this struct
        public override int GetHashCode()
        { 
            int hashCode = -73919966;
            hashCode = hashCode * -1521134295 + File.GetHashCode();
            hashCode = hashCode * -1521134295 + Rank.GetHashCode();
            return hashCode;
        }
    }
}
