using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Encapsulation_demo
    {
        class Program
        {
            static void Main(string[] args)
            {
                home h = new home();
                h.demo();
            }
        }

        class home
        {
            int i;
            protected int j;

            public void demo()
            {
                Console.Write("\n\n\t Value of i = {0} & value of j = {1} ");
                Console.ReadLine();
            }
           
        }
    }
}
