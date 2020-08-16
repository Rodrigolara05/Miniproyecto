using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.Controllers;

namespace UnitTest.WebApp.Controllers
{
    [TestClass]
    public class CommentControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            CommentController _controller = new CommentController();
            //Act
            PartialViewResult viewResult = _controller.CommentsByPhotoId(1) as PartialViewResult;
            //Assert
            Assert.IsInstanceOfType(viewResult.Model, new List<Comment>().GetType());
        }
    }
}
