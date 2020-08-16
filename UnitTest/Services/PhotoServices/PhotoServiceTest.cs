using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.PhotoServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Services.PhotoServices
{
    [TestClass]
    public class PhotoServiceTest
    {
        [TestMethod]
        public void GetPhotos()
        {
            //Arrange
            PhotoService photoService = new PhotoService();
            //Act
            int _count = photoService.GetPhotos().Count;
            //Assert
            Assert.IsTrue(_count > 0);
        }
    }
}
