using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OldPhonePadApp;

namespace OldPhonePadApp.Tests
{
    [TestClass]
    public class OldPhonePadTests
    {
        [TestMethod]
        public void OldPhonePad_EmptyString_ReturnsEmptyString()
        {
            string input = string.Empty;
            string expected = string.Empty;

            string result = OldPhonePadApp.OldPhonePad(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void OldPhonePad_SimpleInput_ReturnsConvertedString()
        {
            string input = "4433555 555666#";
            string expected = "HELLO";

            string result = OldPhonePadApp.OldPhonePad(input);

            Assert.AreEqual(expected, result);
        }

    }
}