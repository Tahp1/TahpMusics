using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace TahpMusic.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            TahpMusicDbContext context =
           app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TahpMusicDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Musics.Any())
            {
                context.Musics.AddRange(
                new Music
                {
                    TenCaKhuc = "Như ngày hôm qua",
                    CaSi = "Sơn Tùng M-TP",

                    TheLoai = "Nhạc-Trẻ",
                    Gia = 11.98m
                },
                new Music
                {
                    TenCaKhuc = "No No No",
                    CaSi = "TheFatRat",

                    TheLoai = "EDM",
                    Gia = 17.46m
                },
                new Music
                {
                    TenCaKhuc = "Best of Me",
                    CaSi = "NEFFEX",

                    TheLoai = "EDM",
                    Gia = 13.41m
                },
                new Music
                {
                    TenCaKhuc = "Thủ Đô Cypher",
                    CaSi = "Beck'Stage X Biti's Hunter ( RPT Orijinn, LOW G, RZMas, RPT MCK)",

                    TheLoai = "Rap",
                    Gia = 18.69m
                },
                new Music
                {
                    TenCaKhuc = "Tình Cha",
                    CaSi = "Ngọc Sơn",

                    TheLoai = "Bolero",
                    Gia = 31.26m
                }
                );
                context.SaveChanges();
            }
        }
    }
}
