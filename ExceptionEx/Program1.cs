using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionAssignment3
{
    class Program1
    {
        int result;
        Program1()
        {
            result = 0;
        }

        public void calcdiv(int a, int b)
        {
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n\nException caught: {0}", e);
            }
            finally
            {
                if (b != 0)
                {
                    Console.WriteLine("\n\n\tResult: {0}", result);
                }
            }

        }
        static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.calcdiv(2, 2);
            p.calcdiv(1, 0);
            p.calcdiv(200, 10);
            p.calcdiv(5000, 0);
            Console.ReadLine();
        }
    }
}
