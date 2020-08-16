using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.CommentServices;

namespace WebApp.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController()
        {
            _commentService = new CommentService();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CommentsByPhotoId(int photoId)
        {
            List<Comment> _list = _commentService.GetCommentsByPhotoId(photoId) ?? new List<Comment>();
            return PartialView("Index", _list);
        }
    }
}
