using Entities;
using Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.CommentServices
{
    public class CommentService : ICommentService
    {
        private readonly Util _util;
        public CommentService()
        {
            _util = new Util("https://jsonplaceholder.typicode.com/");
        }
        public List<Comment> GetComments()
        {
            List<Comment> comments;
            try
            {
                comments = _util.Invocar<List<Comment>>("Comments");
            }
            catch
            {
                comments = null;
            }
            return comments;
        }

        public List<Comment> GetCommentsByPhotoId(int photoId)
        {
            List<Comment> comments;
            try
            {
                comments = _util.Invocar<List<Comment>>("Comments")
                    .Where(item => item.PostId == photoId).ToList();
            }
            catch
            {
                comments = null;
            }
            return comments;
        }
    }
}
