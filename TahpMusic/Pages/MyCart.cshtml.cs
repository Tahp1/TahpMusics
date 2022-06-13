using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TahpMusic.MyTagHelper;
using TahpMusic.Models;
using System.Linq;
namespace TahpMusic.Pages
{
    public class MyCartModel : PageModel
    {
        private ITahpMusicRepository repository;
        public MyCartModel(ITahpMusicRepository repo, MyCart myCartService)
        {
            repository = repo;
            myCart = myCartService;
        }
        public MyCart myCart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long musicId, string returnUrl)
        {
            Music music = repository.Musics
            .FirstOrDefault(b => b.MusicID == musicId);
            myCart.AddItem(music, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long musicId, string returnUrl)
        {
            myCart.RemoveLine(myCart.Lines.First(cl =>
            cl.Music.MusicID == musicId).Music);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

