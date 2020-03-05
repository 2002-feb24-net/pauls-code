using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {3,2,1,4,6,8,9};
            Sort(list);
            Print(list);
        }

        public static List<int> Sort(List<int> L)
        {
            for (int i = L.Count - 2; i >= 0; i--)
            {
                if (L[i] > L[i + 1])
                {
                    int a = L[i];
                    L[i] = L[i+1];
                    L[i+1] = a;
                    
                    i = L.Count - 1;
                }
            }

            return L;
        }
        
        public static void Print(List<int> L)
        {
            
            for (int i = 0; i < L.Count; i++)
            {
                System.Console.Write(L[i] + " ");
            }
        }
    }
}
