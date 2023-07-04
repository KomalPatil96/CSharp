using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumDemo
{
    class Enum
    {
        enum level
        {
            low, medium, high
        }
        static void Main(string[] args)
        {
            level mylevel = level.high;
            Console.WriteLine(mylevel);
            Console.ReadLine();
    
        }
    }

    //enum level
    //{
    //    low,medium,high
    //}

}
