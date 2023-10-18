﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BarcodeStandard;

namespace BarcodeStandardTests.Symbologies
{
    [TestClass]
    public class Code39Tests
    {
        private readonly Barcode _barcode = new()
        {
            EncodedType = Type.Code39,
        };

        [DataTestMethod]
        [DataRow("038000356216", "1001011011010101001101101011011001010101101001011010101001101101010100110110101010011011010110110010101011010011010101011001101010101100101011011010010101101011001101010100101101101")]
        [DataRow("123456789012", "1001011011010110100101011010110010101101101100101010101001101011011010011010101011001101010101001011011011010010110101011001011010101001101101011010010101101011001010110100101101101")]
        [DataRow("192794729478", "1001011011010110100101011010110010110101011001010110101001011011010110010110101010011010110101001011011010110010101101011001011010101001101011010100101101101101001011010100101101101")]
        public void EncodeBarcode(string data, string expected)
        {
            _barcode.Encode(data);
            Assert.AreEqual(expected, _barcode.EncodedValue, $"{_barcode.EncodedType}");
        }
    }
}