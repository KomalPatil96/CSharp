using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            fruits f1 = new fruits();
            fruits f2 = new Orange();    
            fruits f3 = new Greeps();  //object create with base class & Child class
            f1.colours();
            f2.colours();
            f3.colours();
            Console.ReadLine();
        }
    }

    class fruits
    {
        public virtual void colours()  //by using virtual keyword method can access to override a method
        {
            Console.WriteLine("variety of colors in fruits");
            //Console.ReadLine();
        }
    }

    class Orange:fruits
    {
        public override void colours()
        {
            Console.WriteLine("Orange color is orange");
          //  Console.ReadLine();
        }
    }

    class Greeps: Orange
    {
        public override void colours()
        {
            Console.WriteLine("Greeps color is greenish");
           // Console.ReadLine();
        }
    }
}
