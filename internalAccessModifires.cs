using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifires
{
    class internalAccessModifires  //Access within same assembly or same project
    {
        internal string name;   //use like a public access modifire
        internal string color;  

        internal void printinformation2()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("color:" + color);
            Console.ReadLine();
        }
    }
}
