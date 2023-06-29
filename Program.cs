using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class car
    {
        //public string model;

        public car(string modelName)
        {
            Console.WriteLine(modelName);
            // model = "Audi";
            //model = modelName;

        }
        static void Main(string[] args)
        {
             //car mycar = new car();                //without parameter
             //Console.WriteLine(mycar.model);

            car mycar2 = new car("Audi");      //with parameter
            //Console.WriteLine(mycar2.model);
            Console.ReadLine();
        }
    }
}  
