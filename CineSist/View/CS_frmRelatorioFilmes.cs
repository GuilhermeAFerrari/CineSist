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
    public partial class CS_frmRelatorioFilmes : Form
    {
        //criação de instância para usar o formulário CS_frmRelatorioFilmes
        private static CS_frmRelatorioFilmes relatorioFillme = null;

        public CS_frmRelatorioFilmes()
        {
            InitializeComponent();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmRelatorioFilmes getInstance()
        {

            if (relatorioFillme == null)
            {
                relatorioFillme = new CS_frmRelatorioFilmes();
            }

            return (relatorioFillme);
        }

        private void CS_frmRelatorioFilmes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            relatorioFillme = null;
        }

        private void CS_frmRelatorioFilmes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_CinesistDataSet1.TB_Filme' table. You can move, or remove it, as needed.
            this.TB_FilmeTableAdapter.Fill(this.BD_CinesistDataSet1.TB_Filme);

            this.reportViewer1.RefreshReport();
        }
    }
}
