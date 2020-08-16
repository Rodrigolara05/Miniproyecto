using Entities;
using Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services.PhotoServices
{
    public class PhotoService : IPhotoService
    {
        private readonly Util _util;
        public PhotoService()
        {
            _util = new Util("https://jsonplaceholder.typicode.com/");
        }
        public List<Photo> GetPhotosByAlbum(int AlbumId)
        {
            List<Photo> photos;
            try
            {
                photos = _util.Invocar<List<Photo>>("Photos")
                    .Where(item => item.AlbumId == AlbumId).ToList();
            }
            catch
            {
                photos = null;
            }
            return photos;
        }

        public List<Photo> GetPhotos()
        {
            List<Photo> photos;
            try
            {
                photos = _util.Invocar<List<Photo>>("Photos");
            }
            catch
            {
                photos = null;
            }
            return photos;
        }
    }
}
