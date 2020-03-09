using System;
using System.Collections.Generic;

namespace FibonacciSequence
{
    class Program
    {
        static List<int> fib = new List<int>{0,1};
        static void Main(string[] args)
        {
            
            // System.Console.WriteLine("Enter your choice for ");

            System.Console.WriteLine("Enter how many fibonacci numbers to calculate");
            string input = Console.ReadLine();
            if (input == "1")
            {
            fib = FibonacciIterative(input);
            }
            else if(input == "2")
            {
            FibonacciRecursive(input);
            }
            Print();
        }

        static List<int> FibonacciIterative(int j)
        {
            for (int i = 1; i < j; i++)
            {
                fib.Add(fib[i] + fib[i-1]);
            }
            return fib;
        }

        static int FibonacciRecursive(int j)
        {
            if (j == 0) return 0;
            if (j == 1) return 1;
            if (j < fib.Count) return fib[j];
            int i = FibonacciRecursive(j-2) + FibonacciRecursive(j-1);
            fib.Add(i);
            return i;
        }

        static void Print()
        {
            foreach (var item in fib)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}
