using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class Connection
{
    private string connectionString = @"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vicky\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\ScreenSound.mdf;Integrated Security=True;Connect Timeout=30;";

    public SqlConnection ObterConexao()
    {
        return new SqlConnection(connectionString);
    }

    public IEnumerable<Artista> Listar()
    {
        var lista = new List<Artista>();
        using var connection = ObterConexao();
        connection.Open();

        string sql = "SELECT * FROM Artistas";
        SqlCommand command = new SqlCommand(sql, connection);
        using SqlDataReader dataReader = command.ExecuteReader();

        while (dataReader.Read())
        {
            string nomeArtista = Convert.ToString(dataReader["Nome"]);
            string bioArtista = Convert.ToString(dataReader["Bio"]);
            int idArtista = Convert.ToInt32(dataReader["Id"]);
            Artista artista = new(nomeArtista, bioArtista) {Id = idArtista};

            lista.Add(artista);
        }
        return lista;
    }
}