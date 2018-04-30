using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Задание_10_Практикум_12;

namespace Задание_10_Практикум_12.Tests
{
    [TestClass]
    public class CommercialTests
    {
        [TestMethod]
        public void isLicenseOver()
        {
            //arrange
            Commercial commercial = new Commercial("Drweb", "kasperskiy", 1000, new DateTime(2018, 02, 17), 50);
            bool expected = true;
            //act
            bool actual = commercial.isLicenseOver();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
