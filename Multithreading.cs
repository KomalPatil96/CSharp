using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading
{
   public class Multithreading
    {
        static void Main(string[] args)
        {
            
            Thread t2 = new Thread(new ThreadStart(information.details1));
            Thread t1 = new Thread(new ThreadStart(information.Thread1));
            t2.Start();           
            //t1.Join();
            t1.Start();
            // Console.ReadLine();
        }
    }

   public class information
    {
        public static void details1()
        {
            Console.WriteLine("Hi, I am Komal");
            Thread.Sleep(5000);           
            // Console.ReadLine();
        }
        //public static void details2()
        //{
        //    Console.WriteLine("I am from Kolhapur.");
        //    Thread.Sleep(1000);
        //    //Console.ReadLine();
        //}
        public static void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(5000);
            }
        }
    }
}
