using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CineSist
{
    class CS_clsConexao
    {
        public SqlConnection conexao = new SqlConnection();

        public void conectar()
        {
            conexao.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Guilherme\Desktop\CineSist\CineSist\DataBase\BD_Cinesist.mdf;Integrated Security=True";
            conexao.Open();
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
