using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using testi2;
using testi2.Controllers;

namespace testi2.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Data()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Data() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SuburbUV()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.SuburbUV() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Trend()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Trend() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Sunglasses()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Sunglasses() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Protector()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Protector() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Suncream()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Suncream() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Education()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Education() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Cloth()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Cloth() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Hat()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Hat() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DamTre()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.DamTre() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NewSkinDmg()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.NewSkinDmg() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Eyedamage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Eyedamage() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Skindamage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Skindamage() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Treatment()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Treatment() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
