using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class StarUp
    {
        public static void Main(string[] cmd)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);
            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());    
        }
    }
}
