using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[4] { "Maruti", "BMW", "Ford", "Ferrari" };
            Console.WriteLine(cars[2]);
            Console.WriteLine("\n");

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);

            }
            Console.WriteLine("\n");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();
        }
    }
}
