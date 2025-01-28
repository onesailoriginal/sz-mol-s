using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            zsardaniel zsd = new zsardaniel();
            int testnum1 = 0;
            int testnum2 = 3;
            int testnum3 = -5;

            int testExpected1 = 0;
            int testnum1Res = zsd.Parameter(testnum1);
            Assert.AreEqual(testExpected1, testnum1Res);

            int testExpected2 = 15;
            int testnum2Res = zsd.Parameter(testnum2);
            Assert.AreEqual(testExpected2, testnum2Res);

            int testExpected3 = -25;
            int testnum3Res = zsd.Parameter(testnum3);
            Assert.AreEqual(testExpected3, testnum3Res);




        }
        [TestMethod]
        public void TestMethod2()
        {
            zsardaniel zsd = new zsardaniel();
            int testnum1 = 3;
            int testnum1_b = 7;
            double test1Expected = 3.333333333;
            double testnum1Res = zsd.Parameter2(testnum1, testnum1_b);
            Assert.AreEqual(test1Expected, testnum1Res, 0.2);

            int testnum2 = 8;
            int testnum2_b = 5;
            double test2Expected = 2.6;
            double testnum2Res = zsd.Parameter2(testnum2, testnum2_b);
            Assert.AreEqual(test2Expected, testnum2Res);

            int testnum3 = 9;
            int testnum3_b = 9;
            int test3Expected = 2;
            double testnum3Res = zsd.Parameter2(testnum3, testnum3_b);
            Assert.AreEqual(test3Expected, testnum3Res);


            int testnum4 = 4;
            int testnum4_b = 2;
            int test4Expected = 3;
            double testnum4Res = zsd.Parameter2(testnum4, testnum4_b);
            Assert.AreEqual(test4Expected, testnum4Res);

        }
        [TestMethod]
        public void TestMethod3()
        {
            zsardaniel2 zsd = new zsardaniel2();
            int testnum1 = 0;
            int testnum2 = 7;
            int testnum3 = -7;

            int test1Expected = 0;
            int test1Res = zsd.Parameter(testnum1);
            Assert.AreEqual(test1Expected, test1Res);


            int test2Expected = 1;
            int test2Res = zsd.Parameter(testnum2);
            Assert.AreEqual(test2Expected, test2Res);

            int test3Expected = -1;
            int test3Res = zsd.Parameter(testnum3);
            Assert.AreEqual(test3Expected, test3Res);

        }
        [TestMethod]
        public void TestMethod4()
        {
            zsardaniel2 zsd = new zsardaniel2();
            double testnum1 = 3.3;
            double testnum2 = 5.5;
            double testnum3 = 6.6;
            double test1Expected = 15.4;
            double test1Res = zsd.Parameter3(testnum1, testnum2, testnum3);
            Assert.AreEqual(test1Expected, test1Res);
        }
    }
}
