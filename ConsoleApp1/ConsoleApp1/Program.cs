using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1, i;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of " + num + " is: " + fact);
            Console.ReadLine();



        }
    }
}
