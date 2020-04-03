using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CineSist
{
    class CS_clsUsuario
    {
        private int mID_Usuario;
        private string mNM_Usuario;
        private string mNM_Senha;
        private string mID_Funcionario;

        public int ID_Usuario
        {
            get { return mID_Usuario; }
            set { mID_Usuario = value; }
        }

        public string NM_Usuario
        {
            get { return mNM_Usuario; }
            set { mNM_Usuario = value; }
        }

        public string NM_Senha
        {
            get { return mNM_Senha; }
            set { mNM_Senha = value; }
        }

        public string ID_Funcionario
        {
            get { return mID_Funcionario; }
            set { mID_Funcionario = value; }
        }

        public string inserirUsuario()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd;

            string mErro = null;

            try
            {
                cmd = new SqlCommand("INSERT INTO TB_USUARIO (ID_USUARIO, NM_USUARIO, NM_SENHA, ID_FUNCIONARIO) VALUES (@ID_USUARIO, @NM_USUARIO, @NM_SENHA, @ID_FUNCIONARIO)", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_USUARIO", mID_Usuario);
                cmd.Parameters.AddWithValue("@NM_USUARIO", mNM_Usuario);
                cmd.Parameters.AddWithValue("@NM_SENHA", mNM_Senha);
                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", mID_Funcionario);
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

        public int autoIncremento(string query)
        {
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

        public Boolean CS_validarUsuario(CS_clsUsuario usuario)
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            Boolean validar = false;

            string query = "SELECT NM_Usuario FROM TB_Usuario WHERE NM_Usuario=@USUARIO";

            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            cmd.Parameters.AddWithValue("@USUARIO", usuario.NM_Usuario);
            SqlDataReader dr = cmd.ExecuteReader();
           

            if (dr.Read())
            {
                string usuario1 = usuario.mNM_Usuario;

                validar = usuario.CS_validarSenha(usuario.mNM_Senha);

                if (!validar)
                {
                    return false; ;
                }
                else
                {
                    return true;
                }
                

                        
            }
            else
            {
                return validar;
                
                
            }
            dr.Close();
            conexao.desconectar();
            
        }

        private Boolean CS_validarSenha(string senha)
        {

            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            Boolean validar = false;

            string query = "SELECT NM_Senha FROM TB_Usuario WHERE NM_Senha=@SENHA";

            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            cmd.Parameters.AddWithValue("@SENHA", senha);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string senha1 = senha;

                return true;



            }
            else
            {
                return validar;

            }
            dr.Close();
            conexao.desconectar();
            

        }

        public string CS_emitirErro(string erro)
        {
            erro = "Login/Senha Invalida";
            return erro;
        }

        public void CS_iniciarSessao()
        {
            CS_frmMenu menu = new CS_frmMenu();
            menu.Show();
            CS_frmLogin login = new CS_frmLogin();
            login.Hide();
        }

        public void CS_redirecionarLogin()
        {
            CS_frmLogin login = new CS_frmLogin();
            login.Show();
            CS_frmPrimeiroAcesso acesso = new CS_frmPrimeiroAcesso();
            acesso.Hide();
        }
    }
}
