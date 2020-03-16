using System;

namespace ClassLibrary1
{
    public class Palindrome : IInterface
    {
        public bool CheckPal(string inputString)
        {

            string first = inputString.Substring(0, inputString.Length / 2);
            char[] arr = inputString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second, StringComparison.InvariantCultureIgnoreCase);

        }
    }
}
