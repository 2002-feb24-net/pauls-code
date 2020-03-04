using System;
using System.Collections.Generic;

namespace Matrices
{

    class TheMatrix
    {
        //fields
        //how will we store the data of this matrix

        // List<int>[,] matrix1 = new List<int>[2,2];  
        
        List<List<int>> matrix = new List<List<int>>(); // list matrix

        List<int> row1 = new List<int>();
        List<int> row2 = new List<int>();    
        // matrix2[0] = new List<int>[2];
        // matrix2[1] = new List<int>[2];

        // List<int>[][] matrix3 = new List<int>[2][];
        // matrix3[0] = new List<int>[2];
        // matrix3[1] = new List<int>[2];
        
        //methods
        //1. some way to fill in the data
        //2. some commone matrix operations
        // (matrix addition, matrix negation, multiplication, transpose)

        public List<List<int>> EnterTheMatrix(int a, int b, int c, int d)
        {
            row1.Add(a);
            row1.Add(b);
            matrix.Add(row1);

            row2.Add(c);
            row2.Add(d);
            matrix.Add(row2);

            return matrix;
        }
        
        public List<List<int>> MatrixAdd(List<List<int>> matrix2)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    matrix[i][j] += matrix2[i][j];
                }
            }
            return matrix;
        }
        
    }


}