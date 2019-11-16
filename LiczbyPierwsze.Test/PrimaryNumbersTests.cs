using System;
using System.Collections.Generic;
using System.Linq;
using LiczbyPierwsze.Main;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiczbyPierwsze.Test
{
    [TestClass]
    public class PrimaryNumbersTests
    {
        [TestMethod]
        public void CanIDetectedNoPrimaryNumber()
        {
            PrimaryNumbers pn = new PrimaryNumbers();
            int notPrimary = 9;
            Assert.IsFalse(pn.IsPrimary(notPrimary));
        }

        [TestMethod]
        public void CanIDetectedPrimaryNumber() {
            PrimaryNumbers pn = new PrimaryNumbers();
            var primaryNumbers = new List<int> {3, 7, 11, 17, 19,31};

            foreach (var primaryNumber in primaryNumbers) {
                Assert.IsTrue(pn.IsPrimary(primaryNumber));
            }
            
        }

        [TestMethod]
        public void CanIGetCount() {
            int limit = 20;
            int count = 8;
            PrimaryNumbers pn = new PrimaryNumbers();
            Assert.AreEqual(count,pn.GetAllToLimit(limit).Count);
        }

        [TestMethod]
        public void CanIGetCorrectNumbers() {
            List<int> expected = new List<int>(){2,3,5,7,11,13,17,19};
            PrimaryNumbers pn = new PrimaryNumbers();
            List<int> actual = pn.GetAllToLimit(20);
            List<int> actual2 = pn.Numbers;
            foreach (int exp in expected) {
                Assert.IsTrue(actual.Any(item=>item==exp));
                Assert.IsTrue(actual2.Any(item => item == exp));
            }
        }

        [TestMethod]
        public void CanICountPrimaryNumbersInScope() {
            int d = 2;
            int g = 15;
            int expected = 6;
            PrimaryNumbers pn = new PrimaryNumbers();
            int actual = pn.CountPrimaryNumbers(d, g);
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CanIGetZeroWhenNoCorrect() {
            int d = 0;
            int g = 15;
            int expected = 0;
            PrimaryNumbers pn = new PrimaryNumbers();
            int actual = pn.CountPrimaryNumbers(d, g);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CanIGetZeroWhenNoCorrect2()
        {
            int d = 25;
            int g = 15;
            int expected = 0;
            PrimaryNumbers pn = new PrimaryNumbers();
            int actual = pn.CountPrimaryNumbers(d, g);
            Assert.AreEqual(expected, actual);
        }
    }
}
