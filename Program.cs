using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinputstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;

            Console.WriteLine("What is your name?");
            username = Console.ReadLine();
            Console.WriteLine("Hello " + username);
            Console.ReadLine();

        }
    }
}
