using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodAccess
{
    class car
    {
        string color = "Red";
        int maxspeed = 200;
        static void Main(string[] args)
        {
            car mycar = new car();
            Console.WriteLine(mycar.color);
            Console.WriteLine(mycar.maxspeed);
            demospeed();

            car2 mycar2 = new car2();
            Console.WriteLine(mycar2.name);
            Console.WriteLine(mycar2.maxspeed);
            Console.ReadLine();         
        }

       static void demospeed()
        {
            Console.WriteLine("This is new car.");
            Console.ReadLine();
        }

    }

    class car2
    {
       public string name = "Audi";
       public int maxspeed = 200;
    }
}
