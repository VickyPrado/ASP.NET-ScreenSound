using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] {"Nome", "Bio", "FotoPerfil"}, new object[] { "Slipknot", "Slipknot é uma banda norte-americana de metal formada em Des Moines, Iowa, em 1995. Seu estilo musical é o nu metal, que explodiu no fim dos anos 1990 nos Estados Unidos.", "https://images8.alphacoders.com/543/543969.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Metallica", "Metallica é uma banda americana de heavy metal. Foi formada em 1981 em Los Angeles pelo vocalista e guitarrista James Hetfield e pelo baterista Lars Ulrich, tendo sido baseada em São Francisco durante a maioria da sua carreira.", "https://c4.wallpaperflare.com/wallpaper/52/20/858/metallica-wallpaper-preview.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Thirty Seconds to Mars", "Thirty Seconds to Mars é uma banda estadunidense de rock alternativo formada em 1998 em Los Angeles, Califórnia. Em 2002 foi lançado o álbum de estreia da banda intitulado 30 Seconds to Mars. O álbum, produzido apenas pelos dois irmãos Jared Leto e Shannon Leto vendeu dois milhões de cópias no mundo.", "https://wallpaper.forfun.com/fetch/eb/ebc864ff7c835046764780749227d11d.jpeg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Escape the Fate", "Escape the Fate é uma banda americana de rock, formada em 2004 em Pahrump, Nevada. Atualmente o grupo é formado por Robert Ortiz, Craig Mabbitt, TJ Bell, Matti Hoffman e Erik Jensen. Ortiz é o único membro original da atual formação do grupo. A banda já lançou quatro EPs e sete álbuns de estúdio.", "https://circlekj.wordpress.com/wp-content/uploads/2013/03/escape_the_fate_wallpaper_by_kerrangcooper.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Avenged Sevenfold", "Avenged Sevenfold é uma banda norte americana de heavy metal, fundada em 1999 em Huntington Beach, Califórnia. A banda consiste no vocalista M. Shadows, nas guitarras Zacky Vengeance e Synyster Gates, no baixo Johnny Christ e na bateria Brooks Wackerman.", "https://c4.wallpaperflare.com/wallpaper/647/948/834/a7x-artist-avenged-sevenfold-band-wallpaper-preview.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Paramore", "Paramore é uma banda americana de rock formada em Franklin, Tennessee no ano de 2004. Desde 2017, seus membros incluem a vocalista principal Hayley Williams, o guitarrista principal Taylor York e o baterista Zac Farro.", "https://wallpapercave.com/wp/ESApMYn.jpg" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Bullet for My Valentine", "Bullet for My Valentine é uma banda de heavy metal galesa de Bridgend, formada em 1998. Fazendo parte da cena musical de Cardiff, a banda é composta atualmente por Matt Tuck, Michael Paget, Jason Bowld e Jamie Mathias.", "https://cdn.wallpapersafari.com/55/45/hwbpoK.jpg" });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
