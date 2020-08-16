using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.AlbumServices;

namespace WebApp.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController()
        {
            _albumService = new AlbumService();
        }

        public IActionResult Index()
        {
            List<Album> _list = _albumService.GetAlbums() ?? new List<Album>();
            return View(_list);
        }
    }
}
