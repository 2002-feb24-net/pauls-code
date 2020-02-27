using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter # of stairs:");
            string line = Console.ReadLine();
            int k = int.Parse(line);

            for (int i = 1; i <= k; i++)
            { 
                int j = k - i;
                string Tag = new string ('#', i);
                string Space = new string (' ', j);
                Console.WriteLine(Space + Tag);
                
            }
        }
    }
}
