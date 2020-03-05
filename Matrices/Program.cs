using System;
using System.Collections.Generic;

namespace Matrices
{
    class Program
    {

        public static void Main(string[] args)
        {
            TheMatrix Matrix1 = new TheMatrix();
            TheMatrix Matrix2 = new TheMatrix();

            string num = "first";

            int[] array1 = EnterTheMatrix(num);
            List<List<int>> matrix1 = Matrix1.MatrixLoaded(array1);
            EscapeTheMatrix(matrix1);
            string choice = MakeYourChoice();

            if (choice == "1")
            {
                num = "second";
                int[] array2 = EnterTheMatrix(num);
                List<List<int>> matrix2 = Matrix2.MatrixLoaded(array2);
                Matrix1.MatrixAdd(matrix2);
            }
            else if (choice == "2")
            {
                Matrix1.NegativeZone();
            }
            else if (choice == "3")
            {
                num = "second";
                int[] array2 = EnterTheMatrix(num);
                List<List<int>> matrix2 = Matrix2.MatrixLoaded(array2);
                Matrix1.AgentSmith(matrix2);
            }
            else if (choice == "4")
            {
                Matrix1.DodgeThis();
            }
            else
            {
                System.Console.WriteLine("Goodbye, Mr. Anderson.");
                return;
            }

            EscapeTheMatrix(matrix1);
        }

        public static int[] EnterTheMatrix(string num)
        {
            System.Console.WriteLine("Select 4 numbers to enter your " + num + " array");
            int[] array = new int[4];
            array[0] = int.Parse(Console.ReadLine());
            array[1] = int.Parse(Console.ReadLine());
            array[2] = int.Parse(Console.ReadLine());
            array[3] = int.Parse(Console.ReadLine());
            return array;
        }

        public static string MakeYourChoice()
        {
            System.Console.WriteLine("Choose your pill:");
            System.Console.WriteLine("1. Redpill (addition)");
            System.Console.WriteLine("2. Bluepill (negation)");
            System.Console.WriteLine("3. Yellowpill (multiplication)");
            System.Console.WriteLine("4. Greenpill (transpose)");
            System.Console.WriteLine("Make your choice. 1, 2, 3, or 4?");
            string choice = Console.ReadLine();
            return choice;
        }
        public static void EscapeTheMatrix(List<List<int>> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                System.Console.Write("| ");
                for (int j = 0; j < array[i].Count; j++)
                {
                    System.Console.Write(array[i][j] + " ");
                }
                System.Console.WriteLine("|");
            }
        }
    }
}
