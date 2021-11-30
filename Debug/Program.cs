using System;
using System.Collections.Generic;
using System.IO;
using TicTacToeCore;
using TicTacToeCore.Engine;
using TicTacToeCore.Models;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();

            var trening = new NeuralNetworkTrening();

            var start = new DateTime();
            start = DateTime.Now;
            Console.WriteLine(start.Hour + ":" + start.Minute);
            
            var winner = trening.SimulateGenerations(10_000_000, 5);
            winner.Weights.SaveWeightToFile("T10Mx5");

            start = DateTime.Now;
            Console.WriteLine(start.Hour + ":" + start.Minute);
        }
    }
}
