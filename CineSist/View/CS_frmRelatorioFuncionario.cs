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
    public partial class CS_frmRelatorioFuncionario : Form
    {
        //criação de instância para usar o formulário CS_frmRelatorioFuncionario
        private static CS_frmRelatorioFuncionario relatorioFuncionario = null;

        public CS_frmRelatorioFuncionario()
        {
            InitializeComponent();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmRelatorioFuncionario getInstance()
        {

            if (relatorioFuncionario == null)
            {
                relatorioFuncionario = new CS_frmRelatorioFuncionario();
            }

            return (relatorioFuncionario);
        }

        private void CS_frmRelatorioFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_CinesistDataSet1.TB_Funcionario' table. You can move, or remove it, as needed.
            this.TB_FuncionarioTableAdapter.Fill(this.BD_CinesistDataSet1.TB_Funcionario);

            this.reportViewer1.RefreshReport();
        }

        private void CS_frmRelatorioFuncionario_FormClosed(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            relatorioFuncionario = null;
        }
    }
}
