using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.PhotoServices
{
    public interface IPhotoService
    {
        public List<Photo> GetPhotos();
        public List<Photo> GetPhotosByAlbum(int AlbumId);
    }
}
