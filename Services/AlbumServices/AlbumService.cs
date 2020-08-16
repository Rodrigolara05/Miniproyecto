using Entities;
using Services.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.AlbumServices
{
    public class AlbumService : IAlbumService
    {
        private readonly Util _util;
        public AlbumService()
        {
            _util = new Util("https://jsonplaceholder.typicode.com/");
        }
        public List<Album> GetAlbums()
        {
            List<Album> albums;
            try
            {
                albums = _util.Invocar<List<Album>>("Albums");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                albums = null;
            }
            return albums;
        }
    }
}
