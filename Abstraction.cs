using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Abstraction
    {
        static void Main(string[] args)
        {
            car2 c2 = new car2();
            c2.mycar();
        }
    }

    abstract class car1
    {
            public abstract void mycar();
        }
    class car2 : car1
    {
            public string color;
            public string name;

            public override void mycar()
            {
                color = "White";
                Console.WriteLine("Color= " + color);
                Console.ReadLine();
            }
    }
}
