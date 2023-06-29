using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinputdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1st value:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a 2nd value:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("\nAddition: a + b =" + c);
            //c = Convert.ToInt32(Console.ReadLine());

            int d = a - b;
            Console.WriteLine("\nSubtraction: a - b =" + d);
           // d = Convert.ToInt32(Console.ReadLine());

            int e = a * b;
            Console.WriteLine("\nmultiplication: a * b =" + e);
           // e = Convert.ToInt32(Console.ReadLine());

            int f = a / b;
            Console.WriteLine("\nDivision: a / b =" + f);
            Convert.ToInt32(Console.ReadLine());
        
        }
    }
}
