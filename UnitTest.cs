using Microsoft.VisualStudio.TestTools.UnitTesting;
using PratciceProgram.BasicProgrms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratciceProgram.BasicProgrms.Tests
{
    [TestClass()]
    public class UnitTest
    {
        [TestMethod()]
        public void checkAnagramTest()
        {
            Anagram anagram = new Anagram();    
            Assert.AreEqual(true,anagram.checkAnagram("pari","ripa"));  
        }


        [TestMethod()]
        public void factorialOfGivenNumberTset()
        {
            FactorialNumber factorialNumber = new FactorialNumber();
            Assert.AreEqual(6, factorialNumber.factorialOfGivenNumber(3));
        }


         [TestMethod()]
         public void CheckPrimeTest()
         {
            Excecute primeNumber = new Excecute();
            Assert.AreEqual(true, primeNumber.CheckPrime(5));
         }



        [TestMethod()]
        public void stringReverseTest()
        {
            ReverseString reverseString = new ReverseString ();
            Assert.AreEqual("irap",reverseString.stringReverse("pari"));
        }



        [TestMethod()]
        public void sumofdigitTest()
        {
            SumOfNumber sumOfNumber = new SumOfNumber();    
            Assert.AreEqual(10, sumOfNumber.sumofdigit(4));
        }


        [TestMethod()]
        public void targetOfSumTest()
        {
            Sum2Problem sum2Problem = new Sum2Problem();
            int[] array = { 1, 3, 5, 3, 2 };
            int n = 5;
            Assert.AreEqual(true, sum2Problem.TargetOfSum(array, 7, n));
        }
    }
}