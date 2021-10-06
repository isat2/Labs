using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_part2
{
    class Program
    {   //5--------------------------
        static void method(string b, params int[] integ)
        {
            int sum = 0;
            int min = integ[0];
            int max = integ[0];
            for (int i=0;i<integ.Length;i++)
            {
                sum += integ[i];
            }
            
            for (int j=0; j<integ.Length; j++)
            {
                if (integ[j] < min)
                {
                    min = integ[j];
                }
                else if (integ[j]>max)
                {
                    max = integ[j];
                }
            }
           
            b = b.Trim(new char[] { 'c', 'u', 's', 'h', 'a' });
           
            Console.WriteLine("Кортеж из функции: ");
            var tuple = ("Sum = "+sum,"Min = " + min, "Max = " + max, "First letter = " + b);
            Console.WriteLine(tuple);
        }
         
        static void Main(string[] args)
        {
           
            int[] arr = new int[] { 1, 2, 3, 4,7, 10 };
            method("Kcusha", arr);


            Console.ReadKey();
        }
    }
}
        

