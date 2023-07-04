using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceAssignment1
{

    public interface ITransaction
    {
        double getamount();
        void showTransaction();
    }

    public class Transaction :ITransaction
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()   //Constructor of class by default
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)  //Constructor with parameters
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getamount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("\n\n\t Transaction:{0} date :{1} Amount: Rs. {2} -/", tCode, date, getamount());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);

            t1.showTransaction();
            t2.showTransaction();
            Console.ReadLine();

        }
    }

    
}
