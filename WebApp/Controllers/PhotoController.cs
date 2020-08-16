using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.PhotoServices;

namespace WebApp.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;

        public PhotoController()
        {
            _photoService = new PhotoService();
        }
        public IActionResult Index()
        {
            List<Photo> _list = _photoService.GetPhotos() ?? new List<Photo>();
            return View(_list);
        }

        public IActionResult PhotosByAlbumId(int AlbumId)
        {
            List<Photo> _list = _photoService.GetPhotosByAlbum(AlbumId) ?? new List<Photo>();
            return View("Index", _list);
        }

    }
}
