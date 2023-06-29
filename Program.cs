using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objectCreation
{
    class car
    {
        string color = "Red";
        int maxspeed = 200;
        static void Main(string[] args)
        {
            car mycar = new car();
            Console.WriteLine(mycar.maxspeed);

            car2 mycar2 = new car2();
            Console.WriteLine(mycar2.color);
            Console.ReadLine();
        }
    }

    class car2
    {
        public string color = "Red";
    }
}
