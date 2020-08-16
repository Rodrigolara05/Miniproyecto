using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CommentServices
{
    public interface ICommentService
    {
        public List<Comment> GetComments();
        public List<Comment> GetCommentsByPhotoId(int photoId);
    }
}
