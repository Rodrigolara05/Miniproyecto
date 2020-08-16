using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.AlbumServices
{
    public interface IAlbumService
    {
        public List<Album> GetAlbums();
    }
}
