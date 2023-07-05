using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionAssignment4
{
    class Program3
    {
        static void Main(string[] args)
        {
            Temperature t = new Temperature();
            try
            {
                t.show();
            }
            catch (expzero e)
            {
                Console.WriteLine("\n\n\t expzero Exception : {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
    public class expzero : ApplicationException
    {
        public expzero(string message)
            : base(message)
        {
        }
    }

    public class Temperature
    {
        int t = 0;
        public void show()
        {
            if (t == 0)
            {
                throw (new expzero("Detected a Zero value"));
            }
            else
            {
                Console.WriteLine(" Tvalue: {0}", t);
            }
        }
    }

}

