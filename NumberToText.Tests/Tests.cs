// Copyright (c) 2019-2020 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftCircuits.NumberToText;
using System.Collections.Generic;

namespace NumberToTextTests
{
    [TestClass]
    public class Tests
    {
        private static readonly List<(decimal, string)> TestData = new List<(decimal, string)>
        {
            (0, "Zero and 00/100"),
            (1, "One and 00/100"),
            (10, "Ten and 00/100"),
            (100, "One hundred and 00/100"),
            (1000, "One thousand and 00/100"),
            (10000, "Ten thousand and 00/100"),
            (100000, "One hundred thousand and 00/100"),
            (1000000, "One million and 00/100"),
            (1, "One and 00/100"),
            (12, "Twelve and 00/100"),
            (123, "One hundred twenty-three and 00/100"),
            (1234, "One thousand, two hundred thirty-four and 00/100"),
            (12345, "Twelve thousand, three hundred forty-five and 00/100"),
            (123456, "One hundred twenty-three thousand, four hundred fifty-six and 00/100"),
            (1234567, "One million, two hundred thirty-four thousand, five hundred sixty-seven and 00/100"),
            (12345678, "Twelve million, three hundred forty-five thousand, six hundred seventy-eight and 00/100"),
            (123456789, "One hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 00/100"),
            (1234567890, "One billion, two hundred thirty-four million, five hundred sixty-seven thousand, eight hundred ninety and 00/100"),
            (1.1m , "One and 10/100"),
            (10.12m , "Ten and 12/100"),
            (100.123m , "One hundred and 12/100"),
            (1000.1234m , "One thousand and 12/100"),
            (1000000.12345m , "One million and 12/100"),
        };

        [TestMethod]
        public void RunTestData()
        {
            NumberToText converter = new NumberToText();
            foreach ((decimal input, string output) in TestData)
                Assert.AreEqual(output, converter.Transform(input));
        }
    }
}
