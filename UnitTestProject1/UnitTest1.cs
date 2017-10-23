using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 1;
            string actual = Class1.CowConter(n);
            string expected = "1 корова";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod11()
        {
            int n = 11;
            string actual = Class1.CowConter(n);
            string expected = "11 коров";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod0()
        {
            int n = 0;
            string actual = Class1.CowConter(n);
            string expected = "0 коров";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int n = 2;
            string actual = Class1.CowConter(n);
            string expected = "2 коровы";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int n = 5;
            string actual = Class1.CowConter(n);
            string expected = "5 коров";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod10()
        {
            int n = 10;
            string actual = Class1.CowConter(n);
            string expected = "10 коров";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod21()
        {
            int n = 21;
            string actual = Class1.CowConter(n);
            string expected = "21 корова";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod101()
        {
            int n = 101;
            string actual = Class1.CowConter(n);
            string expected = "101 корова";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod111()
        {
            int n = 111;
            string actual = Class1.CowConter(n);
            string expected = "111 коров";
            Assert.AreEqual(expected, actual);
        }
    }
}
