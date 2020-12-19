using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HW1
{
    public class FilterListTest  
    {
    
    [Test]                        


        public void FilterList()
        {
            List<object> inputList1 = new List<object>() { 1, 2, "a", "b" };
            List<object> expectedList1 = new List<object>() { 1, 2 };

            var result1 = ListFilter.FilterList(inputList1);

            Assert.AreEqual(expectedList1, result1, "Error!");


            List<object> inputList2 = new List<object>() { 1, 2, "a", "b", 1, "c" };
            List<object> expectedList2 = new List<object>() { 1, 2, 1 };

            var result2 = ListFilter.FilterList(inputList2);

            Assert.AreEqual(expectedList2, result2, "Error!");


            List<object> inputList3 = new List<object>() { 1, 2, "2", "3", 0 };
            List<object> expectedList3 = new List<object>() { 1, 2, 0 };

            var result3 = ListFilter.FilterList(inputList3);

            Assert.AreEqual(expectedList3, result3, "Error!");
        }
    }


    public class FindLetterTest                             
    {

        [TestCase ("stress",'t')]
        [TestCase("road", 'r')]
        [TestCase("cOoc", ' ')]
        [TestCase("Moon", 'M')]

        public void LetterFinder(string input, char expected)
        {
            var result = FindLetter.FirstNonRepeatingLetter(input);

            Assert.AreEqual(expected, result, "Error!");
        }
    }


    public class DigitalRootTest                            
    {
        [TestCase(336, 3)]
        [TestCase(336893, 5)]
        [TestCase(33609907, 1)]

        public void DigitalRootFinder(int input, int expectedResult)
        {
            var result = DigitalRoot.FindDigitalRoot(input);

            Assert.AreEqual(expectedResult, result);
        }
    }


    public class FindPairsTest                              
    {
        [TestCase(new int[] {1,3,6,2,2,0,4,5}, 4)]
        [TestCase(new int[] { 8, 6, 2, 2, 0, 4, 5 }, 3)]
        [TestCase(new int[] { 1, 3, 9 }, 0)]

        public void PairsFinder(int[] input, int expectedResult)
        {
            var result = FindPairs.PairsFinderFunction(input);

            Assert.AreEqual(expectedResult, result);
        }
    }

    
    public class SortFriendListTest                         
    {
        [TestCase("Fred:Cornwill;Mike:Cornwill;Joshua:Aames", "(AAMES, JOSHUA)(CORNWILL, FRED)(CORNWILL, MIKE)")]
        [TestCase("Fred:Morgenstern;Vladimir:Putin;Barak:Obama;Vadim:Obama", "(MORGENSTERN, FRED)(OBAMA, BARAK)(OBAMA, VADIM)(PUTIN, VLADIMIR)")]


        public void SortFriendList(string input, string expectedResult)
        {
            var result = FriendListSorter.Sorter(input);

            Assert.AreEqual(expectedResult, result);
        }
    }


    public class RearrangeDigitsTest                        
    {
        [TestCase(631, -1)]
        [TestCase(1090, 1900)]
        [TestCase(534976,536479 )]
        [TestCase(1132, 1213)]

        public void Digitsrearranger(int input, int expectedResult)
        {
            var result = RearrangeDigits.Rearrange(input);

            Assert.AreEqual(expectedResult, result);
        }
    }

    public class NumberToIP_Test                           
    {
        [TestCase((UInt32)0, "0.0.0.0")]
        [TestCase((UInt32)62, "0.0.0.62")]
        [TestCase(2149583361, "128.32.10.1")]

        public void NumberToIP(UInt32 input, string expectedResult)
        {
            var result = NumberToIPConverter.Convert(input);

            Assert.AreEqual(expectedResult, result);
        }

    }
}







