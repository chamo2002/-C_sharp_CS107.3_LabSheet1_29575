using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

 5 Console.Write("Enter a number:");
   num=Convert.ToInt32(Console.ReadLine());

   {
       if (num <= 0)
       {
           Console.WriteLine("ERROR");
       }
       else
       {
           for (int i = 1; i <= num; i++)
           {
               sum += i;
           }
       }
   }
   Console.WriteLine("The Sum:" + sum);
   Console.ReadLine();
        }
    }
}
