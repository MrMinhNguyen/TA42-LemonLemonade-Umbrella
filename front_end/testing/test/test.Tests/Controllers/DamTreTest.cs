using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web.Mvc;
using test.Controllers;

namespace test.Tests.Controllers
{
    [TestClass]
    public class DamTreTest
    {
        [TestMethod]
        public void DamTre()
        {
            // Arrange
            DamTreController controller = new DamTreController();

            // Act
            ViewResult result = controller.DamTre() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Eyedamage()
        {
            // Arrange
            DamTreController controller = new DamTreController();

            // Act
            ViewResult result = controller.Eyedamage() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NewSkinDmg()
        {
            // Arrange
            DamTreController controller = new DamTreController();

            // Act
            ViewResult result = controller.NewSkinDmg() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Skindamage()
        {
            // Arrange
            DamTreController controller = new DamTreController();

            // Act
            ViewResult result = controller.Skindamage() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Treatment()
        {
            // Arrange
            DamTreController controller = new DamTreController();

            // Act
            ViewResult result = controller.Treatment() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
