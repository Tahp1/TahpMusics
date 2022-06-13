using System.Collections.Generic;
namespace TahpMusic.Models.ViewModels
{
    public class MusicsListViewModel
    {
        public IEnumerable<Music> Musics { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentGenre { get; set; }
    }
}

