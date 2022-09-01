using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Tesla : IEletricCar, ICar
    {
        public string Model { get; set; }
        public string Color { get ; set ; }
        public int Batter { get ; set ; }
        public string Star()
        { return "Engine start"; }
        public string Stop()
        {
            return "Breaaak!";
        }
        public Tesla(string model, string color, int batter)
        {
            Model = model;
            Color = color;
            Batter = batter;
        }

        public override string ToString()
        {
            return Color + " Tesla " + Model + " with " + Batter + " Batteries" + Star() + "\n" + Stop();
        }
    }
}
