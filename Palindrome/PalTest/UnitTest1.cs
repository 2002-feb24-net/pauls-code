using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace PalTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance to test:
            Palindrome pal = new Palindrome();
            // Define a test input and output value:
            bool expectedResult = true;
            string input = "abba";
            // Run the method under test:
            bool actualResult = pal.CheckPal(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void TestMethod2()
        {
            // Create an instance to test:
            Palindrome pal = new Palindrome();
            // Define a test input and output value:
            bool expectedResult = true;
            string input = "aba";
            // Run the method under test:
            bool actualResult = pal.CheckPal(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void TestMethod3()
        {
            // Create an instance to test:
            Palindrome pal = new Palindrome();
            // Define a test input and output value:
            bool expectedResult = true;
            string input = "Abba";
            // Run the method under test:
            bool actualResult = pal.CheckPal(input);
            // Verify the result:
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
