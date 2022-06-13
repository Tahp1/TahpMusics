using System.Linq;
namespace TahpMusic.Models
{
    public interface ITahpMusicRepository
    {
        IQueryable<Music> Musics { get; }
        void SaveMusic(Music b);
        void CreateMusic(Music b);
        void DeleteMusic(Music b);
    }
}
