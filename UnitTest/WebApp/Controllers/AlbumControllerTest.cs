using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest.WebApp.Controllers
{
    [TestClass]
    public class AlbumControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            AlbumController albumController = new AlbumController();
            //Act
            ViewResult viewResult = albumController.Index() as ViewResult;
            //Assert
            Assert.IsNotNull(viewResult);
        }
    }
}
