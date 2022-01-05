using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_finder
{
    class Program
    {
        static void Main(string[] args)
        {

            //The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2, ...1 and the factorial of zero, 0, is defined as being 1.
            //Solve this using both loops and recursion            

            Console.WriteLine("Welcome to factorial finder!");

            Console.Write("please enter a positive number: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            int i = n;

            if (n < 0)
            {
                Console.WriteLine("please enter a number above 0");
            }

            if (n == 0)
            {
                Console.WriteLine($"the factorial of {i} is {factorial}");
            }


            
        }
    }
}
