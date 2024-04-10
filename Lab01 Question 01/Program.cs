using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Question_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;

            Console.Write("Enter the length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the width:");
            width = Convert.ToInt32(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("Area:" + area);
            Console.ReadLine();
        }
    }
}
