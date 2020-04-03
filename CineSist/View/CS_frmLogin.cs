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
    public partial class CS_frmLogin : Form
    {
        public CS_frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            
            CS_clsUsuario mObjUsuario = new CS_clsUsuario();

            mObjUsuario.NM_Usuario = txtUsuario.Text;
            mObjUsuario.NM_Senha = txtSenha.Text;

            string erro = "";

            Boolean validar =  mObjUsuario.CS_validarUsuario(mObjUsuario);

            if (validar)
            {
                //MessageBox.Show("Entrando");
                mObjUsuario.CS_iniciarSessao();
                this.Hide();
                
            }
            else
            {
               MessageBox.Show(mObjUsuario.CS_emitirErro(erro));
            }
            limparCampos();
        }

        public void limparCampos()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLogin.Checked)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcessar_Enter(object sender, EventArgs e)
        {

        }

        private void CS_frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar_Click(sender, e);
            }
        }

        private void lblPrimeiroAcesso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CS_frmPrimeiroAcesso primeiroAcesso = new CS_frmPrimeiroAcesso();
            primeiroAcesso.Show();
        }
    }
}
