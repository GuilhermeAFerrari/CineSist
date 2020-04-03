using System;
using System.Data;
using System.Data.SqlClient;

namespace CineSist
{
    class CS_clsSessao
    {
        private int mId_Sessao;
        private int mId_Filme;
        private int mId_Sala;
        private int mId_Funcionario;
        private DateTime mDT_Sessao;
        private string mHR_Sessao;
        private float mVL_Inteira;
        private float mVL_Meia;
        private string mST_Situacao;
        private string mVL_Gratuita;


        public int Id_Sessao
        {
            get { return mId_Sessao; }
            set { mId_Sessao = value; }
        }

        public int Id_Filme
        {
            get { return mId_Filme; }
            set { mId_Filme = value; }
        }

        public int Id_Sala
        {
            get { return mId_Sala; }
            set { mId_Sala = value; }
        }

        public int Id_Funcionario
        {
            get { return mId_Funcionario; }
            set { mId_Funcionario = value; }
        }

        public DateTime DT_Sessao
        {
            get { return mDT_Sessao; }
            set { mDT_Sessao = value; }
        }

        public string HR_Sessao
        {
            get { return mHR_Sessao; }
            set { mHR_Sessao = value; }
        }

        public float VL_Inteira
        {
            get { return mVL_Inteira; }
            set { mVL_Inteira = value; }
        }

        public float VL_Meia
        {
            get { return mVL_Meia; }
            set { mVL_Meia = value; }
        }

        public string ST_Situacao
        {
            get { return mST_Situacao; }
            set { mST_Situacao = value; }
        }

        public string VL_Gratuita
        {
            get { return mVL_Gratuita; }
            set { mVL_Gratuita = value; }
        }



        public string inserirSessao()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("INSERT INTO TB_SESSAO (ID_SESSAO, HR_SESSAO, DT_SESSAO, VL_INTEIRA, VL_MEIA, ST_SITUACAO, ID_FILME, ID_SALA, ID_FUNCIONARIO, VL_GRATUITA) VALUES (@ID_SESSAO, @HR_SESSAO, @DT_SESSAO, @VL_INTEIRA, @VL_MEIA, @ST_SITUACAO, @ID_FILME, @ID_SALA, @ID_FUNCIONARIO, @VL_GRATUITA)", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_SESSAO", mId_Sessao);
                cmd.Parameters.AddWithValue("@HR_SESSAO", mHR_Sessao);
                cmd.Parameters.AddWithValue("@DT_SESSAO", mDT_Sessao);
                cmd.Parameters.AddWithValue("@VL_INTEIRA", mVL_Inteira);
                cmd.Parameters.AddWithValue("@VL_MEIA", mVL_Meia);
                cmd.Parameters.AddWithValue("@ST_SITUACAO", mST_Situacao);
                cmd.Parameters.AddWithValue("@ID_FILME", mId_Filme);
                cmd.Parameters.AddWithValue("@ID_SALA", mId_Sala);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", mId_Funcionario);
                cmd.Parameters.AddWithValue("@VL_GRATUITA", "Gratuito");
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

        public string atualizarSessao()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            

            string mErro = null;

            try
            {
                SqlCommand cmd;
                cmd = new SqlCommand("UPDATE TB_SESSAO SET  HR_SESSAO=@HR_SESSAO, DT_SESSAO=@DT_SESSAO, VL_INTEIRA=@VL_INTEIRA, VL_MEIA=@VL_MEIA, ST_SITUACAO=@ST_SITUACAO, ID_FILME=@ID_FILME, ID_SALA=@ID_SALA, ID_FUNCIONARIO=@ID_FUNCIONARIO, VL_GRATUITA=@VL_GRATUITA WHERE ID_SESSAO=@ID_SESSAO", conexao.conexao);
              
                cmd.Parameters.AddWithValue("@HR_SESSAO", mHR_Sessao);
                cmd.Parameters.AddWithValue("@DT_SESSAO", mDT_Sessao);
                cmd.Parameters.AddWithValue("@VL_INTEIRA", mVL_Inteira);
                cmd.Parameters.AddWithValue("@VL_MEIA", mVL_Meia);
                cmd.Parameters.AddWithValue("@ST_SITUACAO", mST_Situacao);
                cmd.Parameters.AddWithValue("@ID_FILME", mId_Filme);
                cmd.Parameters.AddWithValue("@ID_SALA", mId_Sala);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", mId_Funcionario);
                cmd.Parameters.AddWithValue("@VL_GRATUITA","Gratuito");
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

        public SqlDataReader getSessao()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("Select ID_SESSAO, HR_SESSAO, DT_SESSAO, VL_INTEIRA, VL_MEIA, ST_SITUACAO, tb_filme.nm_filme, ID_SALA, ID_FUNCIONARIO, VL_GRATUITA FROM TB_SESSAO inner Join tb_filme on tb_sessao.id_filme = tb_filme.id_filme WHERE ST_SITUACAO = 'ABERTA'", conexao.conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            //conexao.desconectar();
            return dr;
        }

        public string inativarSessao(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("UPDATE TB_SESSAO SET  ST_SITUACAO=@ST_SITUACAO WHERE ID_SESSAO = @ID_SESSAO", conexao.conexao);
                cmd.Parameters.AddWithValue("@ST_SITUACAO", "INATIVO");
                cmd.Parameters.AddWithValue("@ID_SESSAO", id);
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

        public CS_clsSessao exibirDados(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_SESSAO WHERE ID_SESSAO=@ID", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

            CS_clsSessao mObjSessao = new CS_clsSessao();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjSessao.Id_Sessao = Convert.ToInt32(dr[("ID_SESSAO")]);
                mObjSessao.HR_Sessao = dr[("HR_SESSAO")].ToString();
                mObjSessao.DT_Sessao = Convert.ToDateTime(dr[("DT_SESSAO")]);
                mObjSessao.VL_Inteira = Convert.ToSingle(dr[("VL_INTEIRA")]);
                mObjSessao.VL_Meia = Convert.ToSingle(dr[("VL_MEIA")]);
                mObjSessao.ST_Situacao = dr[("ST_SITUACAO")].ToString();
                mObjSessao.Id_Filme = Convert.ToInt32(dr[("ID_FILME")]);
                mObjSessao.Id_Sala = Convert.ToInt32(dr[("ID_SALA")]);
                mObjSessao.Id_Funcionario = Convert.ToInt32(dr[("ID_FUNCIONARIO")]);
                mObjSessao.VL_Gratuita = dr[("VL_GRATUITA")].ToString();
                return mObjSessao;
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

        public CS_clsSessao exibirIdSessao(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_SESSAO WHERE ID_SESSAO=@ID", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

            CS_clsSessao mObjSessao = new CS_clsSessao();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjSessao.Id_Sessao = Convert.ToInt32(dr[("ID_SESSAO")]);
                return mObjSessao;
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

        public CS_clsSessao verificarSala(string id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT ID_SALA FROM TB_SESSAO WHERE ID_SESSAO=@ID", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

            CS_clsSessao mObjSessao = new CS_clsSessao();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjSessao.Id_Sala = Convert.ToInt32(dr[("ID_SALA")]);

                return mObjSessao;
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
    }
}
