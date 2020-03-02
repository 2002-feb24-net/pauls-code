using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 7;

            for (int i = 1; i < 9; i++)
            { 
                string Tag = new string ('#', i);
                string Space = new string (' ', j);
                Console.WriteLine(Space + Tag);
                j--;
            }
        }
    }
}
