using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // like arrays, each list instance can contain only type of data at a time
            // which is chosen when list is created.
            // unlike arrays, lists can grow or shrink in size

            List<int> numbers = new List<int>();
            // starts empty by default
            int howMany = numbers.Count;  // just like array.Length, gives list size
            numbers.Add(123);  // adds to end of the list

            int firstItem = numbers[0];
            numbers.Insert(0, 1000); // inserts '1000' at index 0 (the beginning)
            numbers.Contains();  // a boolean to check membership in the list
            numbers.Contains(500);  // returns FALSE
            numbers.IndexOf();  // to find first index of given item
            numbers.RemoveAt();  // removes the item at a given index
            numbers.Remove();  // removes the first instance of a given item 

            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }



        }
    }
}
