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
    public partial class CS_frmMenu : Form
    {
        int clickGerenciamento = 0;
        int clickRelatorios = 0;
        public CS_frmMenu()
        {
            InitializeComponent();
            this.ControlBox = false;
            
        }

        public void esconderMenu()
        {
            btnGerenciarFilme.Visible = false;
            btnGerenciarSessao.Visible = false;
            btnGerenciarFuncionario.Visible = false;
        }
        public void mostrarMenu()
        {
            btnGerenciarFilme.Visible = true;
            btnGerenciarSessao.Visible = true;
            btnGerenciarFuncionario.Visible = true;
        }

        public void esconderRelatorios()
        {
            btnRepFilme.Visible = false;
            btnRepSessoes.Visible = false;
            btnRepFuncionario.Visible = false;
            btnRepIngressos.Visible = false;
        }
        public void mostrarRelatorios()
        {
            btnRepFilme.Visible = true;
            btnRepSessoes.Visible = true;
            btnRepFuncionario.Visible = true;
            btnRepIngressos.Visible = true;
        }

        private void CS_frmMenu_Load(object sender, EventArgs e)
        {
            esconderMenu();
            esconderRelatorios();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVenderIngresso_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmVenderIngresso venderIngresso = CS_frmVenderIngresso.getInstance();
              venderIngresso.MdiParent = this;
              venderIngresso.Show();
        }

        private void btnGerenciarFilme_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmInserirFilme inserirFilme = CS_frmInserirFilme.getInstance();
            inserirFilme.MdiParent = this;
            inserirFilme.Show();
        }

        private void btnGerenciarSessao_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmInserirSessao gerenciarSessao = CS_frmInserirSessao.getInstance();
            gerenciarSessao.MdiParent = this;
            gerenciarSessao.Show();
        }

        private void btnGerenciarFuncionario_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmGerenciarFuncionario gerenciarFuncionario = CS_frmGerenciarFuncionario.getInstance();
            gerenciarFuncionario.MdiParent = this;
            gerenciarFuncionario.Show();
        }

        private void btnGerenciamento_Click(object sender, EventArgs e)
        {
            

            if (clickGerenciamento == 0)
            {
                mostrarMenu();
                clickGerenciamento=1;

            }
            else
            {
                esconderMenu();
                esconderRelatorios();
                clickGerenciamento=0;
            }
        }

     

        private void btnGerenciamento_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CS_frmMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
	        {
                Application.Exit();       
	        }
            if (e.KeyCode == Keys.F4)
            {
                btnGerenciamento_Click(sender, e);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnVenderIngresso_Click(sender, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                btnRelatorio_Click(sender, e);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (clickRelatorios == 0)
            {
                mostrarRelatorios();
                clickRelatorios = 1;

            }
            else
            {
                esconderRelatorios();
                esconderMenu();
                clickRelatorios = 0;
            }
        }

        private void btnRepFilme_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmRelatorioFilmes relatorioFilme = CS_frmRelatorioFilmes.getInstance();
            relatorioFilme.Show();
        }

        private void btnRepFuncionario_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmRelatorioFuncionario relatorioFuncionario = CS_frmRelatorioFuncionario.getInstance();
            relatorioFuncionario.Show();

        }

        private void btnRepSessoes_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmRelatorioSessoes relatorioSessoes = CS_frmRelatorioSessoes.getInstance();
            relatorioSessoes.Show();
        }

        private void btnRepIngressos_Click(object sender, EventArgs e)
        {
            //instanciando o form com o método getInstance
            CS_frmRelatorioIngressos relatorioIngressos = CS_frmRelatorioIngressos.getInstance();
            relatorioIngressos.Show();
        }
    }

    }
