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
    public partial class CS_frmVenderIngresso : Form
    {
        //criação de instância para usar o formulário CS_frmVenderIngresso
        private static CS_frmVenderIngresso frmVenderIngresso = null;
        public CS_frmVenderIngresso()
        {
            InitializeComponent();
            lstVSessao.Columns.Add("ID", 30);
            lstVSessao.Columns.Add("HORÁRIO", 70);
            lstVSessao.Columns.Add("DATA", 70);
            lstVSessao.Columns.Add("INTEIRA", 70);
            lstVSessao.Columns.Add("MEIA", 70);
            lstVSessao.Columns.Add("SITUAÇÃO", 70);
            lstVSessao.Columns.Add("FILME", 70);
            lstVSessao.Columns.Add("SALA", 70);
            lstVSessao.Columns.Add("FUNCIONARIO", 70);
            lstVSessao.Columns.Add("GRATUITA", 70);
            carregarListSessao();


            lstVIngresso.Columns.Add("ID", 30);
            lstVIngresso.Columns.Add("TIPO", 70);
            lstVIngresso.Columns.Add("POLTRONA", 70);
            lstVIngresso.Columns.Add("SESSAO", 70);
            carregarListIngresso();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmVenderIngresso getInstance()
        {
            if (frmVenderIngresso == null)
            {
                frmVenderIngresso = new CS_frmVenderIngresso();
            }
            return (frmVenderIngresso);
        }

        public void carregarListSessao()
        {
            lstVSessao.Items.Clear();
            CS_clsSessao objSessaos = new CS_clsSessao();
            SqlDataReader dr = objSessaos.getSessao();

            while (dr.Read())
            {
                ListViewItem lstV = new ListViewItem(dr["ID_SESSAO"].ToString());
                lstV.SubItems.Add(dr["HR_SESSAO"].ToString());
                lstV.SubItems.Add(dr["DT_SESSAO"].ToString());
                lstV.SubItems.Add(dr["VL_INTEIRA"].ToString());
                lstV.SubItems.Add(dr["VL_MEIA"].ToString());
                lstV.SubItems.Add(dr["ST_SITUACAO"].ToString());
                lstV.SubItems.Add(dr["NM_FILME"].ToString());
                lstV.SubItems.Add(dr["ID_SALA"].ToString());
                lstV.SubItems.Add(dr["ID_FUNCIONARIO"].ToString());
                lstV.SubItems.Add(dr["VL_GRATUITA"].ToString());
                lstVSessao.Items.Add(lstV);
            }
        }

        public void carregarListIngresso()
        {
            lstVIngresso.Items.Clear();
            CS_clsIngresso objIngresso = new CS_clsIngresso();
            SqlDataReader dr = objIngresso.getIngresso();

            while (dr.Read())
            {
                ListViewItem lstV = new ListViewItem(dr["ID_INGRESSO"].ToString());
                lstV.SubItems.Add(dr["NM_TIPO"].ToString());
                lstV.SubItems.Add(dr["ID_POLTRONA"].ToString());
                lstV.SubItems.Add(dr["ID_SESSAO"].ToString());
          
                lstVIngresso.Items.Add(lstV);
            }
        }

        private void gbxVenderIngresso_Enter(object sender, EventArgs e)
        {

        }

        private void lstVSessao_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in lstVSessao.SelectedItems)
            {
                CS_clsSessao objSessoes = new CS_clsSessao();
                objSessoes = objSessoes.exibirIdSessao(Convert.ToInt32(item.Text));
                txtIdSessao.Text = objSessoes.Id_Sessao.ToString();
            }

            CS_clsSessao objSessao = new CS_clsSessao();

            
            objSessao = objSessao.verificarSala(txtIdSessao.Text);
                //Verifica qual sala está a sessão
                if(objSessao.Id_Sala.Equals(1))
                {

                    //instanciando o form com o método getInstance
                    CS_frmVendaIngresso vendaIngresso = new CS_frmVendaIngresso(this);
                    //abrir form de vender ingresso sala 1
                    vendaIngresso.Show();
                }
                else
                {
                    //instanciando o form com o método getInstance
                    CS_frmVenderIngressoSala2 vendaIngresso2 = new CS_frmVenderIngressoSala2(this);
                    //abrir form de vender ingresso sala 1
                    vendaIngresso2.Show();
                }
        }

        private void fechandoForm(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            frmVenderIngresso = null;
        }

        private void CS_frmVenderIngresso_Click(object sender, EventArgs e)
        {
            carregarListIngresso();
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConcluirVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingressos contabilizados");
            this.Close();
        }
    }
}
