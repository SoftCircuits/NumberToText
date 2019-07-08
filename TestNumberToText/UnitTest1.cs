// Copyright (c) 2019 Jonathan Wood (www.softcircuits.com)
// Licensed under the MIT license.
//
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftCircuits.NumberToText;

namespace TestNumberToText
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tests()
        {
            NumberToText converter = new NumberToText();

            Assert.AreEqual("Zero and 00/100", converter.Transform(0));
            Assert.AreEqual("One and 00/100", converter.Transform(1));
            Assert.AreEqual("Ten and 00/100", converter.Transform(10));
            Assert.AreEqual("One hundred and 00/100", converter.Transform(100));
            Assert.AreEqual("One thousand and 00/100", converter.Transform(1000));
            Assert.AreEqual("One million and 00/100", converter.Transform(1000000));

            Assert.AreEqual("One hundred twenty-three and 00/100", converter.Transform(123));
            Assert.AreEqual("One hundred twenty-three thousand, four hundred fifty-six and 00/100", converter.Transform(123456));
            Assert.AreEqual("Twelve million, three hundred forty-five thousand, six hundred seventy-eight and 00/100", converter.Transform(12345678));

            Assert.AreEqual("One and 10/100", converter.Transform(1.1m));
            Assert.AreEqual("Ten and 12/100", converter.Transform(10.12m));
            Assert.AreEqual("One hundred and 12/100", converter.Transform(100.123m));
            Assert.AreEqual("One thousand and 12/100", converter.Transform(1000.1234m));
            Assert.AreEqual("One million and 12/100", converter.Transform(1000000.12345m));
        }
    }
}
