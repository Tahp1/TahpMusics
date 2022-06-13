using Microsoft.EntityFrameworkCore;
namespace TahpMusic.Models
{
    public class TahpMusicDbContext : DbContext
    {
        public TahpMusicDbContext(DbContextOptions<TahpMusicDbContext> options)
        : base(options) { }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}


