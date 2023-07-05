using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionAssignment5
{
    class Program4
    {
        static int DivideByTwo(int num)
        {
            if ((num & 1) == 1)
            
                throw new ArgumentException(String.Format("{0} is not an even number", num), "num");
              
                return num / 2;     // num is even, return half of its value


        }
        static void Main(string[] args)
        {
            int[] values = { 10, 7 };
            foreach (var value in values)
            {
                try
                {
                    Console.WriteLine("{0} divided by 2 is {1}", value, DivideByTwo(value));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("{0}: {1}", e.GetType().Name, e.Message);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
