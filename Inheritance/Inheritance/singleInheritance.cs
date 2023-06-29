using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class vehicles      //parent class
    {
        private int speed;
        public void show()
        {
            speed = 120;
            Console.WriteLine("speed=" + speed);
            Console.ReadLine();
        }
    }

    class cars : vehicles     //child class
    {
        private string name;
        public void show1()
        {
            name = "Audi";
            Console.WriteLine("name=" + name);
            Console.ReadLine();
        }
    }
}
