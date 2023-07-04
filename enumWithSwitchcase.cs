using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumWithSwitchcase
{
    class enumWithSwitchcase
    {
        static void Main(string[] args)
        {
            level myvar = level.medium;
            Console.WriteLine(myvar);

            switch(myvar)
            {
                case level.low:
                    Console.WriteLine("Level is low.");
                    break;

                case level.medium:
                    Console.WriteLine("Level is medium.");
                    break;

                case level.high:
                    Console.WriteLine("Level is high.");
                    break;

            }
            Console.ReadLine();
        }
    }

    enum level
    {
        low,medium,high
    }
}
