using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    System.Console.WriteLine("Fizzbuzz"); // 66
                    fizzbuzz ++;
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz"); // 267
                    fizz ++;
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz"); // 134
                    buzz ++;
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("The total amount of 'Fizzes' are : " + fizz);
            System.Console.WriteLine("The total amount of 'Buzzes' are : " + buzz);
            System.Console.WriteLine("The total amount of 'Fizzbuzzes' are : " + fizzbuzz);

        }
    }
}
