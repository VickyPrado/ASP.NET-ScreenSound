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

    /*
    public void Atualizar(Artista artista)
    {
        using var connection = new ScreenSoundContext().ObterConexao();
        connection.Open();

        string sql = "UPDATE Artistas SET Nome = @nome, FotoPerfil = @perfilPadrao, Bio = @bio WHERE Id = @id";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@nome", artista.Nome);
        command.Parameters.AddWithValue("@perfilPadrao", artista.FotoPerfil);
        command.Parameters.AddWithValue("@bio", artista.Bio);
        command.Parameters.AddWithValue("@id", artista.Id);

        int retorno = command.ExecuteNonQuery();
        Console.WriteLine($"Linhas afetadas: {retorno}");
    }


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
