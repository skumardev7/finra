using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Finra.Core;

namespace Finra.Tests
{
    [TestClass]
    public class AlphaNumericGeneratorTests
    {
        [TestMethod]
        public void TwoDigitNumber_AllDigitsInKeypad_CorrectCount()
        {
            long input = 25;
            
            AlphaNumericGenerator core = new AlphaNumericGenerator();
            var result = core.GetAlphaNumerics(input,1,10);
            int totalcount = result.Item1;
            int expectedcount = 15;
            Assert.AreEqual(expectedcount, totalcount);
        }

        [TestMethod]
        public void TwoDigitNumber_OneDigitNotInKeypad_CorrectCount()
        {
            long input = 20;

            AlphaNumericGenerator core = new AlphaNumericGenerator();
            var result = core.GetAlphaNumerics(input, 1, 10);
            int totalcount = result.Item1;
            int expectedcount = 3;
            Assert.AreEqual(expectedcount, totalcount);
        }
    }
}
