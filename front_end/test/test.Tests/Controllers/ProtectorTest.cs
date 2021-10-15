using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using test.Controllers;

namespace test.Tests.Controllers
{
    [TestClass]
    public class ProtectorTest
    {
        [TestMethod]
        public void Cloth()
        {
            // Arrange
            ProtectorController controller = new ProtectorController();

            // Act
            ViewResult result = controller.Cloth() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Hat()
        {
            // Arrange
            ProtectorController controller = new ProtectorController();

            // Act
            ViewResult result = controller.Hat() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Protector()
        {
            // Arrange
            ProtectorController controller = new ProtectorController();

            // Act
            ViewResult result = controller.Protector() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Suncream()
        {
            // Arrange
            ProtectorController controller = new ProtectorController();

            // Act
            ViewResult result = controller.Suncream() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Sunglasses()
        {
            // Arrange
            ProtectorController controller = new ProtectorController();

            // Act
            ViewResult result = controller.Sunglasses() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
