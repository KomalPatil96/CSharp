using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifires
{
    class car
    {
        private string name;
        private string color;

        private void printinformation()
        {
            Console.WriteLine("name:" + name);
            Console.WriteLine("color:" + color);
        }
    }
}
