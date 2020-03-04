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

            System.Console.WriteLine("Enter 4 numbers into first matrix");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            List<List<int>> matrix1 = Matrix1.EnterTheMatrix(a,b,c,d);
            System.Console.WriteLine("Enter 4 numbers into second matrix");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            List<List<int>> matrix2 = Matrix2.EnterTheMatrix(a,b,c,d);

            Matrix1.MatrixAdd(matrix2);

            EscapeTheMatrix(matrix1);
        }

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
