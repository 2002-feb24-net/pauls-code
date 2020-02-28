using System;

namespace abbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = GetInput();
            string[] stray = SplitString(str);
            Printabbreviation(stray);
        }

        static string GetInput()  //First method to receive user input
        {
            System.Console.WriteLine("Enter multiple words:");
            string str = Console.ReadLine();
            return str;
        }

        static string[] SplitString(string str)  //Splits phrase into string array 
        {                                        //with each word in its own index
            string[] stray = str.Split(' ');
            return stray;
        }

        static void Printabbreviation(string[] stray)  //Prints first char of each string index
        {
            for (int i = 0; i < stray.Length; i++)
            {
                System.Console.Write(stray[i][0]);
            }
        }
    }
}
