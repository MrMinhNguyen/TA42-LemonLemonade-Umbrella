using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using test.Controllers;

namespace test.Tests.Controllers
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void Data()
        {
            // Arrange
            DataController controller = new DataController();

            // Act
            ViewResult result = controller.Data() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SuburbUV()
        {
            // Arrange
            DataController controller = new DataController();

            // Act
            ViewResult result = controller.SuburbUV() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Trend()
        {
            // Arrange
            DataController controller = new DataController();

            // Act
            ViewResult result = controller.Trend() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
