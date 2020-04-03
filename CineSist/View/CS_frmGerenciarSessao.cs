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
    public partial class CS_frmInserirSessao : Form
    {
        //criação de instância para usar o formulário CS_frmInserirSessao
        private static CS_frmInserirSessao frmInserirSessao = null;
        string query = null;
        public CS_frmInserirSessao()
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
            carregarList();
            telaInicial();
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmInserirSessao getInstance()
        {
            if (frmInserirSessao == null)
            {
                frmInserirSessao = new CS_frmInserirSessao();
            }
            return (frmInserirSessao);
        }
        private void gbxDadosFilme_Enter(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            query = "SELECT MAX(ID_SESSAO)+1 AS ID FROM TB_SESSAO";

            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente inserir este Filme?", "Confirma a Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsSessao mObjSessao = new CS_clsSessao();

                try
                {
                    mObjSessao.Id_Sessao = autoIncremento(query);
                    mObjSessao.HR_Sessao = cmbHora.Text;
                    mObjSessao.DT_Sessao = Convert.ToDateTime(dtpSessao.Text);
                    mObjSessao.VL_Inteira = Convert.ToSingle(txtValorInteira.Text);
                    mObjSessao.VL_Meia = Convert.ToSingle(txtValorMeia.Text);
                    mObjSessao.ST_Situacao = cmbStatus.Text;
                    mObjSessao.Id_Filme = Convert.ToInt32(cmbFilme.SelectedValue);
                    mObjSessao.Id_Funcionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
                    mObjSessao.Id_Sala = Convert.ToInt32(cmbSala.Text);


                    string mErro = mObjSessao.inserirSessao();

                    if (mErro == null)
                    {
                        MessageBox.Show("Inserido com sucesso");
                    }
                    else
                    {
                         MessageBox.Show(mErro);
                    }

                    telaInicial();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
        private void telaInicial()
        {
            //txtIdFilme.Text = autoIncremento().ToString();
            //txtIdFilme.ReadOnly = true;
            txtIdSessao.Visible = false;
            lblId.Visible = false;
            carregaFilme();
            carregaFuncionario();

            btnIncluir.Enabled = true;
            btnAlterar.Enabled = false;
            btnInativar.Enabled = false;
            btnSalvar.Enabled = false;
            txtIdSessao.Text = "";
            cmbHora.Text = "";
            txtValorInteira.Text = "";
            txtValorMeia.Text = "";
            cmbStatus.Text = "";
            cmbFilme.Text = "";
            cmbFuncionario.Text = "";


            cmbFilme.Focus();
        }

        public void carregaFilme()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("SELECT ID_FILME, NM_FILME FROM TB_FILME  ORDER BY NM_FILME", conexao.conexao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbFilme.DisplayMember = "NM_FILME";
            cmbFilme.ValueMember = "ID_FILME";
            cmbFilme.DataSource = dt;
            conexao.desconectar();
        }
        public void carregaFuncionario()
        {
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("SELECT ID_FUNCIONARIO, NM_FUNCIONARIO FROM TB_FUNCIONARIO  ORDER BY NM_FUNCIONARIO", conexao.conexao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbFuncionario.DisplayMember = "NM_FUNCIONARIO";
            cmbFuncionario.ValueMember = "ID_FUNCIONARIO";
            cmbFuncionario.DataSource = dt;
            conexao.desconectar();
        }

        public void carregarList()
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

        public int autoIncremento()
        {
            int codigo = 0;
            CS_clsConexao conexao = new CS_clsConexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_SESSAO)+1 AS ID FROM TB_SESSAO", conexao.conexao);
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

        private void fechandoForm(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            frmInserirSessao = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxDadosSessao.Enabled = true;
            telaInicial();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gbxDadosSessao.Enabled = true;
            cmbFilme.Focus();
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente atualizar este Filme?", "Confirma a Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsSessao mObjSessao = new CS_clsSessao();

                try
                {
                    mObjSessao.Id_Sessao = Convert.ToInt32(txtIdSessao.Text);
                    mObjSessao.HR_Sessao = cmbHora.Text;
                    mObjSessao.DT_Sessao = Convert.ToDateTime(dtpSessao.Text);
                    mObjSessao.VL_Inteira = Convert.ToSingle(txtValorInteira.Text);
                    mObjSessao.VL_Meia = Convert.ToSingle(txtValorMeia.Text);
                    mObjSessao.ST_Situacao = cmbStatus.Text;
                    mObjSessao.Id_Filme = Convert.ToInt32(cmbFilme.SelectedValue);
                    mObjSessao.Id_Funcionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
                    mObjSessao.Id_Sala = Convert.ToInt32(cmbSala.Text);
                    

                    string mErro = mObjSessao.atualizarSessao();

                    if (mErro == null)
                    {
                        MessageBox.Show("Sessão atualizada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show(mErro);
                    }

                    telaInicial();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lstVSessao_MouseClick(object sender, MouseEventArgs e)
        {
            gbxDadosSessao.Enabled = false;
            foreach (ListViewItem item in lstVSessao.SelectedItems)
            {

                CS_clsSessao objSessao = new CS_clsSessao();

                objSessao = objSessao.exibirDados(Convert.ToInt32(item.Text));

                txtIdSessao.Text = objSessao.Id_Sessao.ToString();
                cmbHora.Text = objSessao.HR_Sessao;
                dtpSessao.Text = objSessao.DT_Sessao.ToString();
                txtValorInteira.Text = objSessao.VL_Inteira.ToString();
                txtValorMeia.Text = objSessao.VL_Meia.ToString();
                cmbStatus.Text = objSessao.ST_Situacao;
                cmbFilme.Text = objSessao.Id_Filme.ToString();
                cmbSala.Text = objSessao.Id_Sala.ToString();
                cmbFuncionario.Text = objSessao.Id_Funcionario.ToString();
                //txtNmDescricao.Text = objSessao.VL_Gratuita;
                btnAlterar.Enabled = true;
                btnIncluir.Enabled = false;
                btnInativar.Enabled = true;
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente Inativar a sessão?", "Confirma a Inativação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsSessao mObjSessao = new CS_clsSessao();
                string mErro = mObjSessao.inativarSessao(Convert.ToInt32(txtIdSessao.Text));

                if (mErro == null)
                {
                    MessageBox.Show("Sessao inativada com sucesso");
                }
                else
                {
                    MessageBox.Show(mErro);
                }
                telaInicial();
            }
        }
    }
}
