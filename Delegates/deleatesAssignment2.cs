using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int renew(int n);

namespace deleatesAssignment2
{
    class deleatesAssignment2
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            renew nc;
            renew nc1 = new renew(AddNum);
            renew nc2 = new renew(MultNum);
            nc = nc1;
            nc += nc2;
            
            nc(4);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
