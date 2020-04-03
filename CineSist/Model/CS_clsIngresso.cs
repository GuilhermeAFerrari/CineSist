using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CineSist
{
    class CS_clsIngresso
    {
        private int mId_Ingresso;
        private string mNM_Tipo;
        private int mId_Poltrona;
        private int mId_Sessao;

        public int Id_Ingresso
        {
            get { return mId_Ingresso; }
            set { mId_Ingresso = value; }
        }

        public string NM_Tipo
        {
            get { return mNM_Tipo; }
            set { mNM_Tipo = value; }
        }

        public int Id_Poltrona
        {
            get { return mId_Poltrona; }
            set { mId_Poltrona = value; }
        }
        public int Id_Sessao
        {
            get { return mId_Sessao; }
            set { mId_Sessao = value; }
        }

        public string inserirIngresso()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("INSERT INTO TB_INGRESSO (ID_INGRESSO, NM_TIPO, ID_POLTRONA, ID_SESSAO) VALUES (@ID_INGRESSO, @NM_TIPO, @ID_POLTRONA, @ID_SESSAO)", conexao.conexao);
                //SqlParameter parametroCaminho = new SqlParameter("@NM_Folder", SqlDbType.Binary);
                cmd.Parameters.AddWithValue("@ID_INGRESSO", mId_Ingresso);
                cmd.Parameters.AddWithValue("@NM_TIPO", mNM_Tipo);
                cmd.Parameters.AddWithValue("@ID_POLTRONA", mId_Poltrona);
                cmd.Parameters.AddWithValue("@ID_SESSAO", mId_Sessao);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
                return mErro;
            }
            catch (Exception ex)
            {
                mErro = ex.Message;
                return mErro;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        public float pegaPrecoInteira(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("Select  VL_Inteira FROM TB_SESSAO inner Join TB_Ingresso on TB_Sessao.ID_Sessao = TB_Ingresso.ID_Sessao WHERE tb_Sessao.ID_Sessao = @ID  ", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", id);
            float preco = 0;

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                preco = Convert.ToSingle(dr[("VL_INTEIRA")]);

                return preco;
            }
            else
            {
                //foreach (Control ctl in this.Controls)
                //  {
                //   if (ctl is TextBox)
                //    ctl.Text = "";
                //  }
                return preco;
            }
            dr.Close();
            conexao.desconectar();
        }

        public float pegaPrecoMeia(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("Select  VL_MEIA FROM TB_SESSAO inner Join TB_Ingresso on TB_Sessao.ID_Sessao = TB_Ingresso.ID_Sessao WHERE tb_Sessao.ID_Sessao = @ID ", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", id);
            float preco = 0;

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                preco = Convert.ToSingle(dr[("VL_INTEIRA")]);

                return preco;
            }
            else
            {
                //foreach (Control ctl in this.Controls)
                //  {
                //   if (ctl is TextBox)
                //    ctl.Text = "";
                //  }
                return preco;
            }
            dr.Close();
            conexao.desconectar();
        }

        public string atualizarIngresso()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("UPDATE TB_INGRESSO SET NM_TIPO=@NM_TIPO, ID_POLTRONA=@ID_POLTRONA, ID_SESSAO=@ID_SESSAO WHERE ID_INGRESSO=@ID_INGRESSO", conexao.conexao);

                //SqlParameter parametroCaminho = new SqlParameter("@NM_Folder", SqlDbType.Binary);
                cmd.Parameters.AddWithValue("@NM_TIPO", mNM_Tipo);
                cmd.Parameters.AddWithValue("@ID_POLTRONA", mId_Poltrona);
                cmd.Parameters.AddWithValue("@ID_SESSAO", mId_Sessao);
                cmd.Parameters.AddWithValue("@ID_INGRESSO", mId_Ingresso);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
                conexao.desconectar();
                return mErro;
            }
            catch (Exception ex)
            {
                mErro = ex.Message;
                return mErro;
            }
            finally
            {
                conexao.desconectar();
            }
        }

        public SqlDataReader getIngresso()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("Select ID_INGRESSO, NM_TIPO, ID_POLTRONA, ID_SESSAO FROM TB_INGRESSO", conexao.conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            //conexao.desconectar();
            return dr;
        }

        public CS_clsIngresso exibirDados(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_INGRESSO WHERE ID_POLTRONA=@ID ", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

            CS_clsIngresso mObjIngresso = new CS_clsIngresso();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjIngresso.Id_Ingresso = Convert.ToInt32(dr[("ID_INGRESSO")]);
                mObjIngresso.NM_Tipo = dr[("NM_TIPO")].ToString();
                mObjIngresso.Id_Poltrona = Convert.ToInt32(dr[("ID_POLTRONA")]);
                mObjIngresso.Id_Sessao = Convert.ToInt32(dr[("ID_SESSAO")]);
                return mObjIngresso;
            }
            else
            {
                //foreach (Control ctl in this.Controls)
                //  {
                //   if (ctl is TextBox)
                //    ctl.Text = "";
                //  }
                return null;
            }
            dr.Close();
            conexao.desconectar();
        }

        public int autoIncremento()
        {
            string query = "SELECT MAX(ID_INGRESSO)+1 AS ID FROM TB_INGRESSO";
            int codigo = 0;
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    codigo = Convert.ToInt32(dr["ID"].ToString());
                    return codigo;
                }
                else
                {
                    codigo = 1;
                    return codigo;
                }
            }
            catch (Exception)
            {
                return 1;
            }
            finally
            {
                dr.Close();
                conexao.desconectar();
            }

        }
    }
}
