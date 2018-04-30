using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Задание_10_Практикум_12;

namespace Задание_10_Практикум_12.Tests
{
    [TestClass]
    public class ShareWareTests
    {
        [TestMethod]
        public void isLicenseOver()
        {
            //arrange
            ShareWare shareWare = new ShareWare("Drweb", "kasperskiy", new DateTime(2018, 02, 17), new DateTime(2018, 05, 17));
            bool expected = true;
            //act
            bool actual = shareWare.isLicenseOver();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}