using System;

namespace abbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetInput();
            string[] stray = SplitString(str);
            Printabbreviation();
        }

        static string GetInput()
        {
            System.Console.WriteLine("Enter multiple words:");
            string str = Console.ReadLine();
            return str:
        }

        static string[] SplitString(string str)
        {
            string[] stray = str.Split(' ');
            return stray;
        }

        static void Printabbreviation(string[] stray)
        {
            for (int i = 0; i < length; i++)
            {
                System.Console.Write(stray[i][0]);
            }
        }
    }
}
