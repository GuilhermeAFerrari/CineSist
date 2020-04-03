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
    public partial class CS_frmRelatorioIngressos : Form
    {
        //criação de instância para usar o formulário CS_frmRelatorioIngressos
        private static CS_frmRelatorioIngressos relatorioIngressos = null;

        public CS_frmRelatorioIngressos()
        {
            InitializeComponent();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmRelatorioIngressos getInstance()
        {

            if (relatorioIngressos == null)
            {
                relatorioIngressos = new CS_frmRelatorioIngressos();
            }

            return (relatorioIngressos);
        }

        private void CS_frmRelatorioIngressos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_CinesistDataSet2.vendaIngresso' table. You can move, or remove it, as needed.
            this.vendaIngressoTableAdapter.Fill(this.BD_CinesistDataSet2.vendaIngresso);

            this.reportViewer1.RefreshReport();
        }

        private void CS_frmRelatorioIngressos_FormClosed(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            relatorioIngressos = null;
        }
    }
}
