using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineSist
{
    public partial class CS_frmRelatorioSessoes : Form
    {
        //criação de instância para usar o formulário CS_frmRelatorioSessoes
        private static CS_frmRelatorioSessoes relatorioSessoes = null;

        public CS_frmRelatorioSessoes()
        {
            InitializeComponent();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmRelatorioSessoes getInstance()
        {

            if (relatorioSessoes == null)
            {
                relatorioSessoes = new CS_frmRelatorioSessoes();
            }

            return (relatorioSessoes);
        }

        private void CS_frmRelatorioSessoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_CinesistDataSet1.TB_Sessao' table. You can move, or remove it, as needed.
            this.TB_SessaoTableAdapter.Fill(this.BD_CinesistDataSet1.TB_Sessao);

            this.reportViewer1.RefreshReport();
        }

        private void CS_frmRelatorioSessoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            relatorioSessoes = null;
        }
    }
}
