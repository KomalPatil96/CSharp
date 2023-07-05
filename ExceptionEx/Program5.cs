using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleCatch
{
    class Program5
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int d = 5;//5
                int c = a / d;

                string f = null;
                Console.WriteLine(f.Length);

                int[] arr = new int[3];
                arr[0] = 11;
                arr[1] = 22;
                arr[2] = 33;
                arr[3] = 44;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
