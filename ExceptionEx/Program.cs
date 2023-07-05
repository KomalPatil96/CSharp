using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exceptionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Directory.GetDirectories("D:\\shri\\");
            }
            catch(DirectoryNotFoundException de)
            {
                Console.WriteLine(de.Message);
            }
            Console.ReadLine();
        }
    }
}
