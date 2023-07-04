﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            car2 c2 = new car2();
            c2.carDetails();
            c2.carName();
        }
    }

    interface vehicles
    {
        void carDetails();
    }

    interface car1
    {
        void carName();
    }

    class car2 : vehicles , car1
    {
        public string color = "White";
        public string name = "Audi";
        public void carDetails()
        {
            Console.WriteLine("color=" + color);
            Console.ReadLine();

        }

        public void carName()
        {
            Console.WriteLine("Name=" + name);
            Console.ReadLine();
        }

    }
}
