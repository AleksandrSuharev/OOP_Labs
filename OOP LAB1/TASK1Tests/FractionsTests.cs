using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laba1_OOP_Fractions2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_OOP_Fractions2.Tests
{
    [TestClass()]
    public class FractionsTests
    {
        [TestMethod()]
        public void Sum_1D5_and_2D3_13D15_returned()
        {
            Fractions fr_1 = new Fractions(1, 5);
            Fractions fr_2 = new Fractions(2, 3);
            string exepected = "13/15";

            string actual = (fr_1 + fr_2).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Sum_1D5_and_3_16D5_returned()
        {
            Fractions fr_1 = new Fractions(1, 5);
            int int_2 = 3;
            string exepected = "16/5";

            string actual = (fr_1 + int_2).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Diff_5D8_and_3D4_Negativ_1D8_returned()
        {
            Fractions fr_1 = new Fractions(5, 8);
            Fractions fr_2 = new Fractions(3, 4);
            string exepected = "-1/8";

            string actual = (fr_1 - fr_2).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Compos_3D5_and_Negativ_5D3_Negativ_1_returned()
        {
            Fractions fr_1 = new Fractions(3, 5);
            Fractions fr_2 = new Fractions(-5, 3);
            string exepected = "-1";

            string actual = (fr_1 * fr_2).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Div_7D3_and_7D1_1D3_returned()
        {
            Fractions fr_1 = new Fractions(7, 3);
            Fractions fr_2 = new Fractions(7, 1);
            string exepected = "1/3";

            string actual = (fr_1 / fr_2).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Div_7D0_and_7D1_1_returned()
        {
            Fractions fr_1 = new Fractions(7, 0);
            Fractions fr_2 = new Fractions(7, 1);
            string exepected = "1";

            string actual = (fr_1 / fr_2).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Negativ_7D2()
        {
            Fractions fr_1 = new Fractions(7, 2);
            string exepected = "-7/2";

            string actual = (-fr_1).ToString();

            Assert.AreEqual(exepected, actual);
        }
        [TestMethod()]
        public void Eq_1D3_and_1D3_true_returned()
        {
            Fractions fr_1 = new Fractions(1, 3);
            Fractions fr_2 = new Fractions(1, 3);

            bool actual = fr_1 == fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void NotEq_1D3_and_Negativ1D3_true_returned()
        {
            Fractions fr_1 = new Fractions(1, 3);
            Fractions fr_2 = new Fractions(-1, 3);

            bool actual = fr_1 != fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void GreaterOrEq_Negativ_1D3_and_Negativ2D3_true_returned()
        {
            Fractions fr_1 = new Fractions(-1, 3);
            Fractions fr_2 = new Fractions(-2, 3);

            bool actual = fr_1 >= fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void GreaterOrEq_Negativ_1D3_and_Negativ1D3_true_returned()
        {
            Fractions fr_1 = new Fractions(-1, 3);
            Fractions fr_2 = new Fractions(-1, 3);

            bool actual = fr_1 >= fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void LessOrEq_5D15_and_2D3_true_returned()
        {
            Fractions fr_1 = new Fractions(5, 15);
            Fractions fr_2 = new Fractions(2, 3);

            bool actual = fr_1 <= fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void LessOrEq_5D15_and_5D15_true_returned()
        {
            Fractions fr_1 = new Fractions(5, 15);
            Fractions fr_2 = new Fractions(5, 15);

            bool actual = fr_1 <= fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Greater_2D3_and_1D6_true_returned()
        {
            Fractions fr_1 = new Fractions(2, 3);
            Fractions fr_2 = new Fractions(1, 6);

            bool actual = fr_1 > fr_2;

            Assert.IsTrue(actual);
        }
        [TestMethod()]
        public void Less_4D18_and_1D3_true_returned()
        {
            Fractions fr_1 = new Fractions(4, 18);
            Fractions fr_2 = new Fractions(1, 3);

            bool actual = fr_1 < fr_2;

            Assert.IsTrue(actual);
        }



    }
}