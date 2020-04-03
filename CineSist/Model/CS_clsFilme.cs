using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace CineSist
{
    class CS_clsFilme
    {
        private int mId_Filme;
        private string mTitulo_Filme;
        private string mNM_Descricao;
        private string mDuracao_Filme;
        private string mGenero_Filme;
        private string mAno_Realizacao;
        private string mNM_Folder;

        public int Id_Filme
        {
            get { return mId_Filme; }
            set { mId_Filme = value; }
        }

        public string Titulo_Filme
        {
            get { return mTitulo_Filme; }
            set { mTitulo_Filme = value; }
        }

        public string NM_Descricao
        {
            get { return mNM_Descricao; }
            set { mNM_Descricao = value; }
        }

        public string Duracao_Filme
        {
            get { return mDuracao_Filme; }
            set { mDuracao_Filme = value; }
        }

        public string Genero_Filme
        {
            get { return mGenero_Filme; }
            set { mGenero_Filme = value; }
        }

        public string Ano_Realizacao
        {
            get { return mAno_Realizacao; }
            set { mAno_Realizacao = value; }
        }
        public string NM_Folder
        {
            get { return mNM_Folder; }
            set { mNM_Folder = value; }
        }

        public string inserirFilme()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("INSERT INTO TB_FILME (ID_FILME, NM_FILME, DS_DESCRICAO, HR_DURACAO, NM_GENERO, DT_ANOREALIZACAO, NM_FOLDER) VALUES (@ID_FILME, @NM_FILME, @DS_DESCRICAO, @HR_DURACAO, @NM_GENERO, @DT_ANOREALIZACAO, @NM_FOLDER)", conexao.conexao);
                //SqlParameter parametroCaminho = new SqlParameter("@NM_Folder", SqlDbType.Binary);
                cmd.Parameters.AddWithValue("@ID_FILME", mId_Filme);
                cmd.Parameters.AddWithValue("@NM_FILME", mTitulo_Filme);
                cmd.Parameters.AddWithValue("@DS_DESCRICAO", mNM_Descricao);
                cmd.Parameters.AddWithValue("@HR_DURACAO", mDuracao_Filme);
                cmd.Parameters.AddWithValue("@NM_GENERO", mGenero_Filme);
                cmd.Parameters.AddWithValue("@DT_ANOREALIZACAO", mAno_Realizacao);
                cmd.Parameters.AddWithValue("@NM_FOLDER", NM_Folder);
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
        public string atualizarFilme()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("UPDATE TB_FILME SET  NM_FILME=@NM_FILME, DS_DESCRICAO=@DS_DESCRICAO, HR_DURACAO=@HR_DURACAO, NM_GENERO=@NM_GENERO, DT_ANOREALIZACAO=@DT_ANOREALIZACAO, NM_FOLDER=@NM_FOLDER WHERE ID_FILME=@ID_FILME", conexao.conexao);

                //SqlParameter parametroCaminho = new SqlParameter("@NM_Folder", SqlDbType.Binary);

                cmd.Parameters.AddWithValue("@NM_FILME", mTitulo_Filme);
                cmd.Parameters.AddWithValue("@DS_DESCRICAO", mNM_Descricao);
                cmd.Parameters.AddWithValue("@HR_DURACAO", mDuracao_Filme);
                cmd.Parameters.AddWithValue("@NM_GENERO", mGenero_Filme);
                cmd.Parameters.AddWithValue("@DT_ANOREALIZACAO", mAno_Realizacao);
                cmd.Parameters.AddWithValue("@NM_FOLDER", NM_Folder);
                cmd.Parameters.AddWithValue("@ID_FILME", mId_Filme);
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

        public CS_clsFilme exibirDados(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_FILME WHERE ID_FILME=@ID ", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

            CS_clsFilme mObjFilme = new CS_clsFilme();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjFilme.Id_Filme = Convert.ToInt32(dr[("ID_FILME")]);
                mObjFilme.Titulo_Filme = dr[("NM_FILME")].ToString();
                mObjFilme.NM_Descricao = dr[("DS_DESCRICAO")].ToString();
                mObjFilme.Duracao_Filme = dr[("HR_DURACAO")].ToString();
                mObjFilme.Genero_Filme = dr[("NM_GENERO")].ToString();
                mObjFilme.Ano_Realizacao = dr[("DT_ANOREALIZACAO")].ToString();
                mObjFilme.NM_Folder = dr[("NM_FOLDER")].ToString();

                return mObjFilme;
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

        public SqlDataReader getFilmes()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("Select ID_FILME, NM_FILME, DS_DESCRICAO, HR_DURACAO, NM_GENERO, DT_ANOREALIZACAO FROM TB_FILME", conexao.conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            //conexao.desconectar();
            return dr;
            


        }


    }
}