using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_LMS
{
    internal class Fibonaci
    {

        static void PrintFibonacciSeries(int N)
        {
            int first = 0, second = 1, next;


            Console.Write("Fibonacci Series: ");

            for (int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    Console.Write(first + " ");
                    continue;
                }
                if (i == 2)
                {
                    Console.Write(second + " ");
                    continue;
                }

                next = first + second;
                first = second;
                second = next;

                Console.Write(next + " ");
            }

            Console.WriteLine();
        }

        static void Main()
        {

            Console.Write("Enter the number of terms in Fibonacci series: ");
            int N = Convert.ToInt32(Console.ReadLine());
            PrintFibonacciSeries(N);
        }
    }
}
