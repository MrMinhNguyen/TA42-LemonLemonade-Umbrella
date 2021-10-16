using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using test;
using test.Controllers;

namespace test.Tests.Controllers
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
        public void FutureUV()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.FutureUV() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProSport()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.ProSport() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }



    }
}
