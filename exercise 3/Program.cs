using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            string line = Console.ReadLine();
            int n = int.Parse(line);

            for (int i = n; i > 1;)
            { 
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    i = i / 2;
                } 
                
                else if (i % 2 == 1)
                {
                    i = (i * 3) + 1;
                }
                if (i == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
