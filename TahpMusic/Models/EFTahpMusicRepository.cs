using System.Linq;
namespace TahpMusic.Models
{
    public class EFTahpMusicRepository : ITahpMusicRepository
    {
        private TahpMusicDbContext context;
        public EFTahpMusicRepository(TahpMusicDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Music> Musics => context.Musics;
        public void CreateMusic(Music b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteMusic(Music b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveMusic(Music b)
        {
            context.SaveChanges();
        }
    }
}

