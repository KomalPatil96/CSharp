using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class vehicles2
    {
        public string color;
        public int speed;

        public void vehiclesDetail()
        {
            color = "White";
            speed = 100;
            Console.WriteLine("Color=" + color);
            Console.WriteLine("Speed=" + speed);
            Console.ReadLine();
        }
    }

    class car1:vehicles2
    {
        public string name;
        public void carName()
        {
            name = "Audi";
            Console.WriteLine("name= " + name);
            Console.ReadLine();
        }
    }

    class car2:car1
    {
        public string name1;
        public void carName2()
        {
            name1 = "BMW";
            Console.WriteLine("name1= " + name1);
            Console.ReadLine();
        }
    }
}
