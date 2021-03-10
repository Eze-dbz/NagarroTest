using Nagarro.App;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Nagarro.App.Tests
{
    [TestClass()]
    public class MyStringTest
    {
        private readonly MyString _mystring = new MyString();
        [TestMethod()]
        public void CalculateStringTest()
        {
            
            string Expected = "h2o w3d, we a1e d3g s2e t2t";

            var actual = _mystring.CalculateString("hello world, we are doing some test");

            Assert.AreEqual(Expected, actual);
        }

        [TestMethod()]
        public void GetStringDelimetersTest()
        {

            List<char> Expected = new List<char> { ',', ' ', ' ', ' ', '/', ' ', ' ', ')', ' ', '?' };

            List<char> actual = _mystring.GetStringDelimeters("hey, how are / you ) doing?");

            CollectionAssert.AreEqual(Expected, actual);
        }

        [TestMethod()]
        public void ConvertStringWordsTest()
        {

            string[] expected =
            {
                "S3h",
                "E3o"
            };
            string[] actual =
            {
                "Smooth",
                "Emilio"
            };


            CollectionAssert.AreEqual(expected, _mystring.ConvertStringWords(actual));
        }

        [TestMethod()]
        public void GetDistinctStringCharactersCountTest()
        {
            int Expected = 3;
            string SActual = "Emilio";
            int actual = _mystring.GetDistinctStringCharactersCount(SActual);
            Assert.AreEqual(Expected, actual);
        }

        [TestMethod()]
        public void ReplaceStringTest()
        {
            string Expected = "h1y,h1w a1e y1u/d3g?";

            string[] words = { "h1y",  "h1w", "a1e", "y1u", "d3g"};

            char[] delimeters = { ',',' ', ' ','/','?' };

            Assert.AreEqual(Expected, _mystring.ReplaceString(words, delimeters));
        }
    }
}


