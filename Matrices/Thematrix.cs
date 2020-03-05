using System;
using System.Collections.Generic;

namespace Matrices
{

    class TheMatrix
    {
        //fields
        //how will we store the data of this matrix 
        
        List<List<int>> matrix = new List<List<int>>(); // list matrix

        List<int> row1 = new List<int>();
        List<int> row2 = new List<int>();    
        
        //methods
        //1. some way to fill in the data
        //2. some commone matrix operations
        // (matrix addition, matrix negation, multiplication, transpose)

        public List<List<int>> MatrixLoaded(int[] array)
        {
            row1.Add(array[0]);
            row1.Add(array[1]);
            matrix.Add(row1);

            row2.Add(array[2]);
            row2.Add(array[3]);
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

        public List<List<int>> NegativeZone()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    matrix[i][j] = matrix[i][j] * -1;
                }
            }
            return matrix;
        }

        public List<List<int>> AgentSmith(List<List<int>> matrix2)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    matrix[i][j] = matrix[i][j] * matrix2[i][j];
                }
            }
            return matrix;
        }

        public List<List<int>> DodgeThis()
        {
            int a;
            a = matrix[0][1];
            matrix[0][1] = matrix[1][0];
            matrix[1][0] = a;
            return matrix;
        }
        
    }


}