using System.Collections.Generic;
using TicTacToeCore.Models;

namespace TicTacToeCore.ExtensionMethods
{
    public static class HashSetClone
    {
        public static HashSet<PieceModel> DeepClone(this HashSet<PieceModel> target) 
        {
            var output = new HashSet<PieceModel>();

            foreach (PieceModel piece in target)
            {
                output.Add(piece);
            }

            return output;
        }
    }
}
