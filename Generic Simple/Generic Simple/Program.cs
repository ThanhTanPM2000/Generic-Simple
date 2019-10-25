using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BitARR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = 5, b = 7;
            double c = 4.1, d = 5.6;
            Swap<int>(ref a, ref b);
            Swap<double>(ref c, ref d);
            Console.WriteLine("số {0} , {1}", a, b);
            Console.WriteLine("số {0} , {1}", c, d);
            Console.ReadLine();
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
