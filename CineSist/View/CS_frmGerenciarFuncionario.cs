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
using CineSist.Model;

namespace CineSist
{
    public partial class CS_frmGerenciarFuncionario : Form
    {
        //criação de instância para usar o formulário CS_frmInserirFilme
        private static CS_frmGerenciarFuncionario frmGerenciarFuncionario = null;

        public CS_frmGerenciarFuncionario()
        {
            InitializeComponent();
            lstVFuncionario.Columns.Add("ID", 30);
            lstVFuncionario.Columns.Add("NOME", 70);
            lstVFuncionario.Columns.Add("CPF", 150);
            lstVFuncionario.Columns.Add("RG", 200);
            lstVFuncionario.Columns.Add("CARGO", 70);
            lstVFuncionario.Columns.Add("SEXO", 70);
            carregarList();
            telaInicial();
        }
        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmGerenciarFuncionario getInstance()
        {

            if (frmGerenciarFuncionario == null)
            {
                frmGerenciarFuncionario = new CS_frmGerenciarFuncionario();
            }

            return (frmGerenciarFuncionario);
        }

        private void fechandoForm(object sender, FormClosedEventArgs e)
        {
            //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            frmGerenciarFuncionario = null;
        }

        private void telaInicial()
        {
            txtIdFuncionario.Visible = false;
            lblId.Visible = false;
            carregarList();
            btnIncluir.Enabled = true;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";
            cmbCargo.Text = "Gerente";
            cmbSexo.Text = "Masculino";
            txtEmail.Text = "";
            txtNome.Focus();
        }

        public void carregarList()
        {
            lstVFuncionario.Items.Clear();
            CS_clsFuncionario objFuncionarios = new CS_clsFuncionario();
            SqlDataReader dr = objFuncionarios.getFuncionarios();

            while (dr.Read())
            {
                ListViewItem lstV = new ListViewItem(dr["ID_FUNCIONARIO"].ToString());
                lstV.SubItems.Add(dr["NM_FUNCIONARIO"].ToString());
                lstV.SubItems.Add(dr["NR_CPF"].ToString());
                lstV.SubItems.Add(dr["NR_RG"].ToString());
                lstV.SubItems.Add(dr["NM_CARGO"].ToString());
                lstV.SubItems.Add(dr["NM_SEXO"].ToString());
                lstVFuncionario.Items.Add(lstV);
            }
        }

        private void lstVFuncionario_Click(object sender, EventArgs e)
        {
            gbxDadosFuncionario.Enabled = false;
            foreach (ListViewItem item in lstVFuncionario.SelectedItems)
            {

                CS_clsFuncionario objFuncionarios = new CS_clsFuncionario();

                objFuncionarios = objFuncionarios.exibirDados(Convert.ToInt32(item.Text));

                txtIdFuncionario.Text = objFuncionarios.ID_Funcionario.ToString();
                txtNome.Text = objFuncionarios.NM_Funcionario;
                txtCpf.Text = objFuncionarios.NR_Cpf;
                txtRg.Text = objFuncionarios.NR_Rg;
                cmbCargo.Text = objFuncionarios.NM_Cargo;
                cmbSexo.Text = objFuncionarios.NM_Sexo;
                txtEmail.Text = objFuncionarios.NM_Email;
                btnAlterar.Enabled = true;
                btnIncluir.Enabled = false;
            }
        }

        public int autoIncremento()
        {
            string query = "SELECT MAX(ID_FUNCIONARIO)+1 AS ID FROM TB_FUNCIONARIO";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxDadosFuncionario.Enabled = true;
            telaInicial();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gbxDadosFuncionario.Enabled = true;
            txtNome.Focus();
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente atualizar este Funcionario?", "Confirma a Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsFuncionario mObjFuncionario = new CS_clsFuncionario();

                try
                {
                    mObjFuncionario.ID_Funcionario = Convert.ToInt32(txtIdFuncionario.Text);
                    mObjFuncionario.NM_Funcionario = txtNome.Text;
                    mObjFuncionario.NR_Cpf = txtCpf.Text;
                    mObjFuncionario.NR_Rg = txtRg.Text;
                    mObjFuncionario.NM_Cargo = cmbCargo.Text;
                    mObjFuncionario.NM_Sexo = cmbSexo.Text;
                    mObjFuncionario.NM_Email = txtEmail.Text;

                    string mErro = mObjFuncionario.atualizarFuncionario();

                    if (mErro == null)
                    {
                        MessageBox.Show("Funcionario atualizado com sucesso");
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente inserir este funcionario?", "Confirma a Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsFuncionario mObjFuncionario = new CS_clsFuncionario();

                try
                {
                    mObjFuncionario.ID_Funcionario = autoIncremento();
                    mObjFuncionario.NM_Funcionario = txtNome.Text;
                    mObjFuncionario.NR_Cpf = txtCpf.Text;
                    mObjFuncionario.NR_Rg = txtRg.Text;
                    mObjFuncionario.NM_Cargo = cmbCargo.Text;
                    mObjFuncionario.NM_Sexo = cmbSexo.Text;
                    mObjFuncionario.NM_Email = txtEmail.Text; ;

                    string mErro = mObjFuncionario.inserirFuncionario();

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
                    MessageBox.Show("Erro catastrofico ");
                }
            }
        }




    }
}
