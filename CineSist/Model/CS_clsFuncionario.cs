using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CineSist
{
    class CS_clsFuncionario
    {
        private int mID_Funcionario;
        private string mNM_Funcionario;
        private string mNR_Cpf;
        private string mNR_Rg;
        private string mNM_Cargo;
        private string mNM_Sexo;
        private string mNM_Email;

        public int ID_Funcionario
        {
            get { return mID_Funcionario; }
            set { mID_Funcionario = value; }
        }

        public string NM_Funcionario
        {
            get { return mNM_Funcionario; }
            set { mNM_Funcionario = value; }
        }

        public string NR_Cpf
        {
            get { return mNR_Cpf; }
            set { mNR_Cpf = value; }
        }

        public string NR_Rg
        {
            get { return mNR_Rg; }
            set { mNR_Rg = value; }
        }

        public string NM_Cargo
        {
            get { return mNM_Cargo; }
            set { mNM_Cargo = value; }
        }

        public string NM_Sexo
        {
            get { return mNM_Sexo; }
            set { mNM_Sexo = value; }
        }

        public string NM_Email
        {
            get { return mNM_Email; }
            set { mNM_Email = value; }
        }

        public string inserirFuncionario()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("INSERT INTO TB_FUNCIONARIO (ID_FUNCIONARIO, NM_FUNCIONARIO, NR_CPF, NR_RG, NM_CARGO, NM_SEXO, NM_EMAIL) VALUES (@ID_FUNCIONARIO, @NM_FUNCIONARIO, @NR_CPF, @NR_RG, @NM_CARGO, @NM_SEXO, @NM_EMAIL)", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", mID_Funcionario);
                cmd.Parameters.AddWithValue("@NM_FUNCIONARIO", mNM_Funcionario);
                cmd.Parameters.AddWithValue("@NR_CPF", mNR_Cpf);
                cmd.Parameters.AddWithValue("@NR_RG", mNR_Rg);
                cmd.Parameters.AddWithValue("@NM_CARGO", mNM_Cargo);
                cmd.Parameters.AddWithValue("@NM_SEXO", mNM_Sexo);
                cmd.Parameters.AddWithValue("@NM_EMAIL", mNM_Email);
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

        

        public string atualizarFuncionario()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("UPDATE TB_FUNCIONARIO SET  NM_FUNCIONARIO=@NM_FUNCIONARIO, NR_CPF=@NR_CPF, NR_RG=@NR_RG, NM_CARGO=@NM_CARGO, NM_SEXO=@NM_SEXO, NM_EMAIL=@NM_EMAIL WHERE ID_FUNCIONARIO=@ID_FUNCIONARIO", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", mID_Funcionario);
                cmd.Parameters.AddWithValue("@NM_FUNCIONARIO", mNM_Funcionario);
                cmd.Parameters.AddWithValue("@NR_CPF", mNR_Cpf);
                cmd.Parameters.AddWithValue("@NR_RG", mNR_Rg);
                cmd.Parameters.AddWithValue("@NM_CARGO", mNM_Cargo);
                cmd.Parameters.AddWithValue("@NM_SEXO", mNM_Sexo);
                cmd.Parameters.AddWithValue("@NM_EMAIL", mNM_Email);
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

        public CS_clsFuncionario exibirDados(int id)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_FUNCIONARIO WHERE ID_FUNCIONARIO=@ID", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

            CS_clsFuncionario mObjFuncionario = new CS_clsFuncionario();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjFuncionario.ID_Funcionario = Convert.ToInt32(dr[("ID_FUNCIONARIO")]);
                mObjFuncionario.NM_Funcionario = dr[("NM_FUNCIONARIO")].ToString();
                mObjFuncionario.NR_Cpf = dr[("NR_CPF")].ToString();
                mObjFuncionario.NR_Rg = dr[("NR_RG")].ToString();
                mObjFuncionario.NM_Cargo = dr[("NM_CARGO")].ToString();
                mObjFuncionario.NM_Sexo = dr[("NM_SEXO")].ToString();
                mObjFuncionario.NM_Email = dr[("NM_EMAIL")].ToString();
                return mObjFuncionario;
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


        public CS_clsFuncionario getFuncionariosByCpf(string texto)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT ID_FUNCIONARIO FROM TB_FUNCIONARIO WHERE NR_CPF=@NR_CPF", conexao.conexao);
            cmd.Parameters.AddWithValue("@NR_CPF", texto);

            CS_clsFuncionario mObjFuncionario = new CS_clsFuncionario();

            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                mObjFuncionario.ID_Funcionario = Convert.ToInt32(dr[("ID_FUNCIONARIO")]);
               
                return mObjFuncionario;
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

        public SqlDataReader getFuncionarios()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("Select ID_FUNCIONARIO, NM_FUNCIONARIO, NR_CPF, NR_RG, NM_CARGO, NM_SEXO, NM_EMAIL FROM TB_FUNCIONARIO", conexao.conexao);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();


            //conexao.desconectar();
            return dr;
        }

    }
}
