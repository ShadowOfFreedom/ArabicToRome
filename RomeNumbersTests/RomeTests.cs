using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomeNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomeNumbers.Tests
{
    [TestClass()]
    public class RomeTests
    {
        [DataTestMethod()]
        [DataRow("I",1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V",5)]    
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        [DataRow("XI", 11)]
        [DataRow("XII", 12)]
        [DataRow("XIII", 13)]
        [DataRow("XIV", 14)]
        [DataRow("XV", 15)]
        [DataRow("MCMLXXXVI", 1986)]
        [DataRow("DCCCLX", 860)]
        [DataRow("CDXXXIX", 439)]
        [DataRow("MMDCCCLXV", 2865)]
        [DataRow("MMXVIII", 2018)]
        [DataRow("MMMCMXCIX", 3999)]
        public void toRomeTest(string value1, int value2)
        {
            Assert.AreEqual(value1, Rome.toRome(value2));
        }
    }
}