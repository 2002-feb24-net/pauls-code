using System;
using System.Collections.Generic;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            TheMatrix Matrix1 = new TheMatrix();
            TheMatrix Matrix2 = new TheMatrix();

            string num = "first";
            System.Console.WriteLine("Enter 4 numbers into " + num + " matrix");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            List<List<int>> matrix1 = Matrix1.EnterTheMatrix(a,b,c,d);

            System.Console.WriteLine("Choose your pill:");
            System.Console.WriteLine("1. Redpill (addition)");
            System.Console.WriteLine("2. Bluepill (negation)");
            System.Console.WriteLine("3. Yellowpill (multiplication)");
            System.Console.WriteLine("4. Greenpill (transpose)");
            System.Console.WriteLine("Make your choice. 1, 2, 3, or 4?");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                num = "second";
                System.Console.WriteLine("Enter 4 numbers into " + num + " matrix");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                List<List<int>> matrix2 = Matrix2.EnterTheMatrix(a,b,c,d);
                Matrix1.MatrixAdd(matrix2);
            }
            else if (choice == "2")
            {
                Matrix1.NegativeZone();
            }
            else if (choice == "3")
            {
                num = "second";
                System.Console.WriteLine("Enter 4 numbers into " + num + " matrix");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                d = int.Parse(Console.ReadLine());
                List<List<int>> matrix2 = Matrix2.EnterTheMatrix(a,b,c,d);
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

        // public static List<List<int>> EnterTheMatrix()
        // {
        //     System.Console.WriteLine("Enter 4 numbers into " + num + " matrix");
        //     a = int.Parse(Console.ReadLine());
        //     b = int.Parse(Console.ReadLine());
        //     c = int.Parse(Console.ReadLine());
        //     d = int.Parse(Console.ReadLine());
        //     List<List<int>> matrix = Matrix1.MatrixLoaded(a,b,c,d);
        //     return matrix;
        // }

        public static void EscapeTheMatrix(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                System.Console.Write("| ");
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    System.Console.Write(matrix[i][j] + " ");
                }
                System.Console.WriteLine("|");
            }
        }
    }
}
