using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlTypes;
using PxtlCa.BigVariant.Core;

namespace PxtlCa.BigVariant.Test
{
    [TestClass]
    public class ClrValueTest
    {
        [TestMethod]
        public void ClrValueInt32Loopback()
        {
            var testVal = 99999999;
            var testSqlVal = new SqlInt32(testVal);
            var testBigVariant = UserDefinedFunctions.BigVariantFromVariant(testSqlVal);
            Assert.AreEqual(testVal, testBigVariant.AsClrObject);
        }

        [TestMethod]
        public void ClrValueNull()
        {
            var testSqlVal = SqlInt32.Null;
            var testBigVariant = UserDefinedFunctions.BigVariantFromVariant(testSqlVal);
            Assert.AreEqual(null, testBigVariant.AsClrObject);
        }
    }
}
