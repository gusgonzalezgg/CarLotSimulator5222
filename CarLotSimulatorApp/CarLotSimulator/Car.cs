using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public static void MakeEngineNoise(string EngineNoise) 
        
        {
            Console.WriteLine(EngineNoise);
        }

        public static void MakeHonkNoise(string HonkNoise) 
        
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
