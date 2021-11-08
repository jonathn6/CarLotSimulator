using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string passedNoise)
        {
            Console.WriteLine($"{passedNoise}");
        }

        public void MakeHonkNoise(string passedNoise)
        {
            Console.WriteLine($"{passedNoise}");
        }

        public Car()
        {

        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = HonkNoise;
            IsDriveable = IsDriveable;
        }
    }
}
