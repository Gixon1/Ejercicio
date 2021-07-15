using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProductoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProductoTrue()
        {
            bool result = ProductoTesting.Program.Producto("Palmolive","15091994");
            Assert.AreEqual(true, result);
        }
    }
}
