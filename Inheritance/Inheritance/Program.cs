using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //single Inheritance
            cars mycar = new cars();  // object created only for child class           
            mycar.show();
            mycar.show1();
            Console.ReadLine();

            //multilevel Inheritance
            car2 c2 = new car2();
            c2.vehiclesDetail();
            c2.carName();
            c2.carName2();
        }
    }

    
}
