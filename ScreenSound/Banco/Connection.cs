using Microsoft.Data.SqlClient;
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
}
