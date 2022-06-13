using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TahpMusic.Models;
using TahpMusic.Models.ViewModels;

namespace TahpMusic.Controllers
{
    public class HomeController : Controller
    {
        private ITahpMusicRepository repository;
        public int PageSize = 4;
        public HomeController(ITahpMusicRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(string theloai, int musicPage = 1)
 => View(new MusicsListViewModel
 {
     Musics = repository.Musics
 .Where(p => theloai == null || p.TheLoai == theloai)
 .OrderBy(p => p.MusicID)
 .Skip((musicPage - 1) * PageSize)
 .Take(PageSize),
     PagingInfo = new PagingInfo
     {
         CurrentPage = musicPage,
         ItemsPerPage = PageSize,
         TotalItems = theloai == null ?
 repository.Musics.Count() :
 repository.Musics.Where(e =>
 e.TheLoai == theloai).Count()
     },
     CurrentGenre = theloai
 });
    }
}
