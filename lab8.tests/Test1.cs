using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace lab8.tests
{
    [TestClass]
    public class EvenSumTests
    {
        [TestMethod]
        public void Test_EvenNumbers()
        {
            Assert.AreEqual(12, Program.SumEven(new int[] { 1, 2, 3, 4, 5, 6 }));
        }
        [TestMethod]
        public void Test_NoEvenNumbers()
        {
            Assert.AreEqual(0, Program.SumEven(new int[] { 1, 3, 5, 7 }));
        }
        [TestMethod]
        public void Test_EmptyArray()
        {
            Assert.AreEqual(0, Program.SumEven(new int[] { }));
        }
        [TestMethod]
        public void Test_NegativeEvenNumbers()
        {
            Assert.AreEqual(-6, Program.SumEven(new int[] { -2, -4, 1, 3 }));
        }
        [TestMethod]
        public void Test_AllEven()
        {
            Assert.AreEqual(20, Program.SumEven(new int[] { 2, 4, 6, 8 }));
        }
        [TestMethod]
        public void Test_ContainsZero()
        {
            Assert.AreEqual(4, Program.SumEven(new int[] { 0, 4, 7 }));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_NullArray_Throws()
        {
            Program.SumEven(null);
        }
    }
}