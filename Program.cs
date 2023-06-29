using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifires
{
    class Program
    {
        static void Main(string[] args)
        {
            //private (does not access methods or other data in another class)
            car mycar = new car();


            //public
            //car2 mycar2 = new car2();
            //mycar2.name = "Audi";
            //mycar2.color = "White";
            //mycar2.printinformation();


            //internal
            internalAccessModifires i1 = new internalAccessModifires();
            i1.name = "Audi";
            i1.color = "black";
            i1.printinformation2();

            //protected


        }
    }
}
