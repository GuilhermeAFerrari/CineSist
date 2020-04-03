using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CineSist
{
    public partial class CS_frmPrimeiroAcesso : Form
    {
        public CS_frmPrimeiroAcesso()
        {
            InitializeComponent();
        }

        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CS_frmLogin frmLogin = new CS_frmLogin();
            frmLogin.Show();
        }

        private void btnBuscarCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CS_clsFuncionario objFunc = new CS_clsFuncionario();

                objFunc = objFunc.getFuncionariosByCpf(txtCpf.Text);



                if (objFunc.ID_Funcionario == 0)
                {
                    MessageBox.Show(objFunc.ID_Funcionario.ToString());
                    MessageBox.Show("Usuario inexistete");
                }
                else
                {
                    string query = "SELECT MAX(ID_USUARIO)+1 AS ID FROM TB_USUARIO";
                    CS_clsUsuario mObjUsuario = new CS_clsUsuario();


                    mObjUsuario.ID_Usuario = mObjUsuario.autoIncremento(query);
                    mObjUsuario.NM_Usuario = txtUsuário.Text;
                    mObjUsuario.NM_Senha = txtSenha.Text;
                    mObjUsuario.ID_Funcionario = objFunc.ID_Funcionario.ToString();

                    string mErro = mObjUsuario.inserirUsuario();

                    if (mErro == null)
                    {
                        MessageBox.Show("Inserido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show(mErro);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro catastrofico 11 ");
            }
            finally
            {
                CS_clsUsuario mObjUsuario = new CS_clsUsuario();
                mObjUsuario.CS_redirecionarLogin();
                this.Hide();
            }
        }

        private void chkLogin1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogin1.Checked)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void chkLogin2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogin2.Checked)
            {
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        


    }
}
