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
            (0m, "Zero and 00/100"),
            (1m, "One and 00/100"),
            (10m, "Ten and 00/100"),
            (100m, "One hundred and 00/100"),
            (1000m, "One thousand and 00/100"),
            (10000m, "Ten thousand and 00/100"),
            (100000m, "One hundred thousand and 00/100"),
            (1000000m, "One million and 00/100"),
            (10000000m, "Ten million and 00/100"),
            (100000000m, "One hundred million and 00/100"),
            (1000000000m, "One billion and 00/100"),
            (10000000000m, "Ten billion and 00/100"),
            (100000000000m, "One hundred billion and 00/100"),
            (1000000000000m, "One trillion and 00/100"),
            (10000000000000m, "Ten trillion and 00/100"),
            (100000000000000m, "One hundred trillion and 00/100"),
            (1000000000000000m, "One quadrillion and 00/100"),
            (10000000000000000m, "Ten quadrillion and 00/100"),
            (100000000000000000m, "One hundred quadrillion and 00/100"),
            (1000000000000000000m, "One quintillion and 00/100"),
            (10000000000000000000m, "Ten quintillion and 00/100"),
            (100000000000000000000m, "One hundred quintillion and 00/100"),
            (1000000000000000000000m, "One sextillion and 00/100"),
            (10000000000000000000000m, "Ten sextillion and 00/100"),
            (100000000000000000000000m, "One hundred sextillion and 00/100"),
            (1000000000000000000000000m, "One septillion and 00/100"),
            (10000000000000000000000000m, "Ten septillion and 00/100"),
            (100000000000000000000000000m, "One hundred septillion and 00/100"),
            (1000000000000000000000000000m, "One octillion and 00/100"),
            (10000000000000000000000000000m, "Ten octillion and 00/100"),

            (12m, "Twelve and 00/100"),
            (123m, "One hundred twenty-three and 00/100"),
            (1234m, "One thousand, two hundred thirty-four and 00/100"),
            (12345m, "Twelve thousand, three hundred forty-five and 00/100"),
            (123456m, "One hundred twenty-three thousand, four hundred fifty-six and 00/100"),
            (1234567m, "One million, two hundred thirty-four thousand, five hundred sixty-seven and 00/100"),
            (12345678m, "Twelve million, three hundred forty-five thousand, six hundred seventy-eight and 00/100"),
            (123456789m, "One hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 00/100"),
            (1234567890m, "One billion, two hundred thirty-four million, five hundred sixty-seven thousand, eight hundred ninety and 00/100"),
            (12345678901m, "Twelve billion, three hundred forty-five million, six hundred seventy-eight thousand, nine hundred one and 00/100"),
            (123456789012m, "One hundred twenty-three billion, four hundred fifty-six million, seven hundred eighty-nine thousand, twelve and 00/100"),
            (1234567890123m, "One trillion, two hundred thirty-four billion, five hundred sixty-seven million, eight hundred ninety thousand, one hundred twenty-three and 00/100"),
            (12345678901234m, "Twelve trillion, three hundred forty-five billion, six hundred seventy-eight million, nine hundred one thousand, two hundred thirty-four and 00/100"),
            (123456789012345m, "One hundred twenty-three trillion, four hundred fifty-six billion, seven hundred eighty-nine million, twelve thousand, three hundred forty-five and 00/100"),
            (1234567890123456m, "One quadrillion, two hundred thirty-four trillion, five hundred sixty-seven billion, eight hundred ninety million, one hundred twenty-three thousand, four hundred fifty-six and 00/100"),
            (12345678901234567m, "Twelve quadrillion, three hundred forty-five trillion, six hundred seventy-eight billion, nine hundred one million, two hundred thirty-four thousand, five hundred sixty-seven and 00/100"),
            (123456789012345678m, "One hundred twenty-three quadrillion, four hundred fifty-six trillion, seven hundred eighty-nine billion, twelve million, three hundred forty-five thousand, six hundred seventy-eight and 00/100"),
            (1234567890123456789m, "One quintillion, two hundred thirty-four quadrillion, five hundred sixty-seven trillion, eight hundred ninety billion, one hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 00/100"),
            (12345678901234567890m, "Twelve quintillion, three hundred forty-five quadrillion, six hundred seventy-eight trillion, nine hundred one billion, two hundred thirty-four million, five hundred sixty-seven thousand, eight hundred ninety and 00/100"),
            (123456789012345678901m, "One hundred twenty-three quintillion, four hundred fifty-six quadrillion, seven hundred eighty-nine trillion, twelve billion, three hundred forty-five million, six hundred seventy-eight thousand, nine hundred one and 00/100"),
            (1234567890123456789012m, "One sextillion, two hundred thirty-four quintillion, five hundred sixty-seven quadrillion, eight hundred ninety trillion, one hundred twenty-three billion, four hundred fifty-six million, seven hundred eighty-nine thousand, twelve and 00/100"),
            (12345678901234567890123m, "Twelve sextillion, three hundred forty-five quintillion, six hundred seventy-eight quadrillion, nine hundred one trillion, two hundred thirty-four billion, five hundred sixty-seven million, eight hundred ninety thousand, one hundred twenty-three and 00/100"),
            (123456789012345678901234m, "One hundred twenty-three sextillion, four hundred fifty-six quintillion, seven hundred eighty-nine quadrillion, twelve trillion, three hundred forty-five billion, six hundred seventy-eight million, nine hundred one thousand, two hundred thirty-four and 00/100"),
            (1234567890123456789012345m, "One septillion, two hundred thirty-four sextillion, five hundred sixty-seven quintillion, eight hundred ninety quadrillion, one hundred twenty-three trillion, four hundred fifty-six billion, seven hundred eighty-nine million, twelve thousand, three hundred forty-five and 00/100"),
            (12345678901234567890123456m, "Twelve septillion, three hundred forty-five sextillion, six hundred seventy-eight quintillion, nine hundred one quadrillion, two hundred thirty-four trillion, five hundred sixty-seven billion, eight hundred ninety million, one hundred twenty-three thousand, four hundred fifty-six and 00/100"),
            (123456789012345678901234567m, "One hundred twenty-three septillion, four hundred fifty-six sextillion, seven hundred eighty-nine quintillion, twelve quadrillion, three hundred forty-five trillion, six hundred seventy-eight billion, nine hundred one million, two hundred thirty-four thousand, five hundred sixty-seven and 00/100"),
            (1234567890123456789012345678m, "One octillion, two hundred thirty-four septillion, five hundred sixty-seven sextillion, eight hundred ninety quintillion, one hundred twenty-three quadrillion, four hundred fifty-six trillion, seven hundred eighty-nine billion, twelve million, three hundred forty-five thousand, six hundred seventy-eight and 00/100"),
            (12345678901234567890123456789m, "Twelve octillion, three hundred forty-five septillion, six hundred seventy-eight sextillion, nine hundred one quintillion, two hundred thirty-four quadrillion, five hundred sixty-seven trillion, eight hundred ninety billion, one hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 00/100"),

            (1.1m, "One and 10/100"),
            (12.12m, "Twelve and 12/100"),
            (123.123m, "One hundred twenty-three and 12/100"),
            (1234.1234m, "One thousand, two hundred thirty-four and 12/100"),
            (12345.12345m, "Twelve thousand, three hundred forty-five and 12/100"),
            (123456.123456m, "One hundred twenty-three thousand, four hundred fifty-six and 12/100"),
            (1234567.1234567m, "One million, two hundred thirty-four thousand, five hundred sixty-seven and 12/100"),
            (12345678.12345678m, "Twelve million, three hundred forty-five thousand, six hundred seventy-eight and 12/100"),
            (123456789.123456789m, "One hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 12/100"),
            (1234567890.1234567890m, "One billion, two hundred thirty-four million, five hundred sixty-seven thousand, eight hundred ninety and 12/100"),
            (12345678901.12345678901m, "Twelve billion, three hundred forty-five million, six hundred seventy-eight thousand, nine hundred one and 12/100"),
            (123456789012.123456789012m, "One hundred twenty-three billion, four hundred fifty-six million, seven hundred eighty-nine thousand, twelve and 12/100"),
            (1234567890123.1234567890123m, "One trillion, two hundred thirty-four billion, five hundred sixty-seven million, eight hundred ninety thousand, one hundred twenty-three and 12/100"),
            (12345678901234.12345678901234m, "Twelve trillion, three hundred forty-five billion, six hundred seventy-eight million, nine hundred one thousand, two hundred thirty-four and 12/100"),
            (123456789012345.123456789012345m, "One hundred twenty-three trillion, four hundred fifty-six billion, seven hundred eighty-nine million, twelve thousand, three hundred forty-five and 12/100"),
            (1234567890123456.1234567890123456m, "One quadrillion, two hundred thirty-four trillion, five hundred sixty-seven billion, eight hundred ninety million, one hundred twenty-three thousand, four hundred fifty-six and 12/100"),
            (12345678901234567.12345678901234567m, "Twelve quadrillion, three hundred forty-five trillion, six hundred seventy-eight billion, nine hundred one million, two hundred thirty-four thousand, five hundred sixty-seven and 12/100"),
            (123456789012345678.123456789012345678m, "One hundred twenty-three quadrillion, four hundred fifty-six trillion, seven hundred eighty-nine billion, twelve million, three hundred forty-five thousand, six hundred seventy-eight and 12/100"),
            (1234567890123456789.1234567890123456789m, "One quintillion, two hundred thirty-four quadrillion, five hundred sixty-seven trillion, eight hundred ninety billion, one hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 12/100"),
            (12345678901234567890.12345678901234567890m, "Twelve quintillion, three hundred forty-five quadrillion, six hundred seventy-eight trillion, nine hundred one billion, two hundred thirty-four million, five hundred sixty-seven thousand, eight hundred ninety and 12/100"),
            (123456789012345678901.123456789012345678901m, "One hundred twenty-three quintillion, four hundred fifty-six quadrillion, seven hundred eighty-nine trillion, twelve billion, three hundred forty-five million, six hundred seventy-eight thousand, nine hundred one and 12/100"),
            (1234567890123456789012.1234567890123456789012m, "One sextillion, two hundred thirty-four quintillion, five hundred sixty-seven quadrillion, eight hundred ninety trillion, one hundred twenty-three billion, four hundred fifty-six million, seven hundred eighty-nine thousand, twelve and 12/100"),
            (12345678901234567890123.12345678901234567890123m, "Twelve sextillion, three hundred forty-five quintillion, six hundred seventy-eight quadrillion, nine hundred one trillion, two hundred thirty-four billion, five hundred sixty-seven million, eight hundred ninety thousand, one hundred twenty-three and 12/100"),
            (123456789012345678901234.123456789012345678901234m, "One hundred twenty-three sextillion, four hundred fifty-six quintillion, seven hundred eighty-nine quadrillion, twelve trillion, three hundred forty-five billion, six hundred seventy-eight million, nine hundred one thousand, two hundred thirty-four and 12/100"),
            (1234567890123456789012345.1234567890123456789012345m, "One septillion, two hundred thirty-four sextillion, five hundred sixty-seven quintillion, eight hundred ninety quadrillion, one hundred twenty-three trillion, four hundred fifty-six billion, seven hundred eighty-nine million, twelve thousand, three hundred forty-five and 12/100"),
            (12345678901234567890123456.12345678901234567890123456m, "Twelve septillion, three hundred forty-five sextillion, six hundred seventy-eight quintillion, nine hundred one quadrillion, two hundred thirty-four trillion, five hundred sixty-seven billion, eight hundred ninety million, one hundred twenty-three thousand, four hundred fifty-six and 12/100"),
            (123456789012345678901234567.123456789012345678901234567m, "One hundred twenty-three septillion, four hundred fifty-six sextillion, seven hundred eighty-nine quintillion, twelve quadrillion, three hundred forty-five trillion, six hundred seventy-eight billion, nine hundred one million, two hundred thirty-four thousand, five hundred sixty-seven and 12/100"),
            (1234567890123456789012345678.1234567890123456789012345678m, "One octillion, two hundred thirty-four septillion, five hundred sixty-seven sextillion, eight hundred ninety quintillion, one hundred twenty-three quadrillion, four hundred fifty-six trillion, seven hundred eighty-nine billion, twelve million, three hundred forty-five thousand, six hundred seventy-eight and 10/100"),
            (12345678901234567890123456789.12345678901234567890123456789m, "Twelve octillion, three hundred forty-five septillion, six hundred seventy-eight sextillion, nine hundred one quintillion, two hundred thirty-four quadrillion, five hundred sixty-seven trillion, eight hundred ninety billion, one hundred twenty-three million, four hundred fifty-six thousand, seven hundred eighty-nine and 00/100"),

            (1.12m, "One and 12/100"),
            (1.123456789m, "One and 12/100"),
            (1.126m, "One and 13/100"),

            (456m, "Four hundred fifty-six and 00/100"),
            (-456m, "Four hundred fifty-six and 00/100"),

            (decimal.MaxValue, "Seventy-nine octillion, two hundred twenty-eight septillion, one hundred sixty-two sextillion, five hundred fourteen quintillion, two hundred sixty-four quadrillion, three hundred thirty-seven trillion, five hundred ninety-three billion, five hundred forty-three million, nine hundred fifty thousand, three hundred thirty-five and 00/100"),
            (decimal.MinValue, "Seventy-nine octillion, two hundred twenty-eight septillion, one hundred sixty-two sextillion, five hundred fourteen quintillion, two hundred sixty-four quadrillion, three hundred thirty-seven trillion, five hundred ninety-three billion, five hundred forty-three million, nine hundred fifty thousand, three hundred thirty-five and 00/100"),
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
