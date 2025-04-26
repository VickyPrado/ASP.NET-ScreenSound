using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Data;

namespace ScreenSound.Banco;

internal class ArtistaDAL
{
    private readonly ScreenSoundContext context;

    public ArtistaDAL()
    {
        context = new ScreenSoundContext();
    }
    public IEnumerable<Artista> Listar()
    {  
        return context.Artistas.ToList();
    }
    
    public void Adicionar(Artista artista)
    {
        context.Artistas.Add(artista);
        context.SaveChanges();
    }

    
    public void Atualizar(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();
    }

    /*
    public void Deletar(int id)
    {
        using var connection = new ScreenSoundContext().ObterConexao();
        connection.Open();

        string sql = "DELETE FROM Artistas WHERE Id = @id";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@id", id);

        int retorno = command.ExecuteNonQuery();
        Console.WriteLine($"Linhas afetadas: {retorno}");
    }
    */
}
