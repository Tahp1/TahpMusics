using Microsoft.EntityFrameworkCore.Migrations;

namespace TahpMusic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    MusicID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenCaKhuc = table.Column<string>(nullable: true),
                    CaSi = table.Column<string>(nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    TheLoai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.MusicID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musics");
        }
    }
}
