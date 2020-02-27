using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = GetInput();
            int[] array = InterpretStringAsArray(input);
            PrintArray(array);
            
            int input2 = GetInput2();
            int[] NewArray = Add(array, input2);
            PrintArray(NewArray);
        }

        static string GetInput()
        {
            System.Console.WriteLine("Enter list of numbers, seperated by spaces");
            string line = Console.ReadLine();
            return line;
        }

        static int[] InterpretStringAsArray(string str)
        {
            string[] sAr = str.Split(' ');
            int[] iAr = new int[sAr.Length];
            for (int i = 0; i < iAr.Length; i++)
            {
                iAr[i] = int.Parse(sAr[i]);
            }
            return iAr;
        }

        static void PrintArray(int[] a)
        {
            foreach (var item in a)
            {
                System.Console.Write(item + " ");
            }
        }        
        
        static int GetInput2()
        {
            System.Console.WriteLine("Enter number to increase list:");
            string line = Console.ReadLine();
            int num = int.Parse(line);
            return num;
        }

        static int[] Add(int[] a, int b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] + b;
            }
            return a;

            // you use "return" to send the return value back to the
            // code that calls this method.
        }
    }
    
}
