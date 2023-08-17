using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            double expectedSum = num1 + num2;
            double actualSum = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedSum, actualSum);

        }

        [TestMethod]
        [DataRow(5, 2)]
        [DataRow(6, 6)]
        [DataRow(10, 4)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            double expectedProduct = num1 * num2;
            double actualProduct = SimpleMath.Multiply(num1, num2);

            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [TestMethod]
        [DataRow(0, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => SimpleMath.Divide(num1, num2)));
        }

        [TestMethod()]
        [DataRow(10, 10)]
        [DataRow(5, 7)]
        [DataRow(6, 0)]
        public void AddTest(double num1, double num2)
        {
            double expectedSum = (double)num1 + (double)num2;
            double actualSum = SimpleMath.Add(num1, num2);

            Assert.AreEqual(expectedSum, actualSum);
        }

        [TestMethod]
        [DataRow(10, 2)]
        [DataRow(25, 5)]
        [DataRow(9, 3)]
        public void Divide_TwoNumbers_ReturnProduct(double num1, double num2)
        {
            double expectedProduct = num1 / num2;
            double actualProduct = SimpleMath.Divide((double)num1, (double)num2);

            Assert.AreEqual(expectedProduct, actualProduct);
        }

        [TestMethod]
        [DataRow(10, 6)]
        [DataRow(5, 3)]
        [DataRow(6, 0)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double expectedDifference = num1 - num2;
            double actualDifference = SimpleMath.Subtract((double)num1, (double)(num2));

            Assert.AreEqual(expectedDifference, actualDifference);
        }
    }
}