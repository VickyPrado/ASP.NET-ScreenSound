using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class ScreenSoundContext: DbContext
{
    public DbSet<Artista> Artistas { get; set; }

    private string connectionString = @"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vicky\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ScreenSound.mdf;Integrated Security=True;Connect Timeout=30;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}