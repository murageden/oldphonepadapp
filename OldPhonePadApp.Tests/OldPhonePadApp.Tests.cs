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

        [TestMethod]
        public void OldPhonePad_Input_With_Single_Zero_Returns_Space_Between()
        {
            string input = "202222022022222#";
            string expected = "A 2 B A";

            string result = OldPhonePadApp.OldPhonePad(input);
            Assert.AreEqual(expected, result);
        
        }
        [TestMethod]
        public void OldPhonePad_Input_With_Double_Zero_Returns_Zero_Between()
        {
            string input = "007777799999 99999 777772222004444777774444#";
            string expected = "0799720474";

            string result = OldPhonePadApp.OldPhonePad(input);
            Assert.AreEqual(expected, result);
        }

    }
}