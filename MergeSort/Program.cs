using System;
using System.Collections.Generic;

namespace MergeSort
{
    class Program
    {
        //Merge sort is a sorting method that uses "recursion" to call a method
        // from within the method definition itself.
        //It entails splitting the unsort list into smaller lists and smaller lists,
        // untill only single item lists remain, whereby lists are then rejoined,
        // one-by-one, in order, till only one new, sorted list remains.

        static void Main(string[] args)
        {
            List<int> newList = new List<int>();
            List<int> sortedList = new List<int>();

            newList = GetInput();

            sortedList = MergeSort(newList);

            Print(sortedList); 

        }

        public static List<int> GetInput()
        {
            System.Console.WriteLine("Enter numbers in any order, one at a time,");
            System.Console.WriteLine("then enter 'SPACE' when you are done");
            List<int> newList = new List<int>();
            string input;
            do
            {
                input = Console.ReadLine();
                newList.Add(int.Parse(input));
            } while (input != " ");
            
            return newList;
        }

        static List<int> MergeSort(List<int> list)
        {
        // 1. split the array in half, left and right
        // 2. keep doint that for each subarray, untill they are size 1
        // 3. combine your two sorted arrays, one-by-one through both of them
        //    keeping the result sorted overall. 

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = list.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for (int i = middle; i < list.Count; i++)
            {
                right.Add(list[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count>0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count>0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());    
                }    
            }
            return result;
        }

        public static void Print(List<int> list)
        {

        }
    }
}
