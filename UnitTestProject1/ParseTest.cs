using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void TestGoodAdditionCasesParseInts()
        {
            string input "1 + 5";
            Parse parse = new Parse();
            string[] array = parse.extractnumbers(input);
            string[] expectarray = { "1", "5" };
            CollectionAssert.AreEqual(expectarray, array);
        }

        [TestMethod]
        public void TestGoodSubtractionCasesParseInts()
        {
            string input "5 - 1";
            Parse parse = new Parse();
            string[] array = parse.extractnumbers(input);
            string[] expectarray = { "5", "1" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodDivisionCasesParseInts()
        {
            string input "5 / 1";
            Parse parse = new Parse();
            string[] array = parse.extractnumbers(input);
            string[] expectarray = { "5", "1" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodMultiplicationCasesParseInts()
        {
            string input "1 * 5";
            Parse parse = new Parse();
            string[] array = parse.extractnumbers(input);
            string[] expectarray = { "1", "5" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodModulusCasesParseInts()
        {
            string input "5 % 1";
            Parse parse = new Parse();
            string[] array = parse.extractnumbers(input);
            string[] expectarray = { "5", "1" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodAdditionCasesParseOps()
        {
            string input "5 + 1";
            Parse parse = new Parse();
            string[] array = parse.extractoperands(input);
            string[] expectarray = { "+" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodSubtractionCasesParseOps()
        {
            string input "5 - 1";
            Parse parse = new Parse();
            string[] array = parse.extractoperands(input);
            string[] expectarray = { "-" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodMultiplicationCasesParseOps()
        {
            string input "5 * 1";
            Parse parse = new Parse();
            string[] array = parse.extractoperands(input);
            string[] expectarray = { "*" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodDivisionCasesParseOps()
        {
            string input "5 / 1";
            Parse parse = new Parse();
            string[] array = parse.extractoperands(input);
            string[] expectarray = { "/" };
            CollectionAssert.AreEqual(expectarray, array);

        }

        [TestMethod]
        public void TestGoodModulusCasesParseOps()
        {
            string input = "5 % 1";
            Parse parse = new Parse();
            char operation = parse.extractoperator(input);
            Assert.AreEqual('%', operation);

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadAdditionCasesBeginning()
        {
            string input = "+ 15";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadSubtractionCasesBeginning()
        {
            string input = "- 15";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadDivisionCasesBeginning()
        {
            string input = "/ 15";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadMultiplicationCasesBeginning()
        {
            string input = "* 15";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadModulusCasesBeginning()
        {
            string input = "% 15";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadAdditionCasesEnd()
        {
            string input = "15 +";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadSubtractionCasesEnd()
        {
            string input = "15 -";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadDivisionCasesEnd()
        {
            string input = "15 /";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadMultiplicationCasesEnd()
        {
            string input = "15 *";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestBadModulusCasesEnd()
        {
            string input = "15 %";
            Parse parse = new Parse();
            parse.extractproperties(input);
        }
    }


}
