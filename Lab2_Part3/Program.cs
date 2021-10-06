using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//6----------------------------


namespace Lab2_Part3
{
    class Program
    {
        static void func1()
        {
            checked
            {
                int a = 2147483647 + 1;
            }

        }
        static void func2()
        {
            unchecked
            {
                int a = 2147483647 + 1;
            }
        }
        static void Main(string[] args)
        {
            func1();
            func2();
            Console.ReadKey();
        }
    }
}
