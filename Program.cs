using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concatiation
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Komal";
            string y = " Patil";
            string result = string.Concat(x, y);
            Console.WriteLine("result:" + result);
            Console.ReadLine();
        }
    }
}
