using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TahpMusic.Models;
namespace TahpMusic.ViewComponents
{
    public class GenreNavigation : ViewComponent
    {
        private ITahpMusicRepository repository;
        public GenreNavigation(ITahpMusicRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTheLoai = RouteData?.Values["theloai"];
            return View(repository.Musics
            .Select(x => x.TheLoai)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}

