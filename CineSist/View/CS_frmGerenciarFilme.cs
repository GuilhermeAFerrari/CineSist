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
using System.IO;
using System.Drawing.Imaging;

namespace CineSist
{
    public partial class CS_frmInserirFilme : Form
    {    
        //criacao de variavel global para uso em auto incremento de diferentes tabelas e caminho
        string query = null;
        string caminho = "";

        //criação de instância para usar o formulário CS_frmInserirFilme
        private static CS_frmInserirFilme frmInserirFilme = null;

        public CS_frmInserirFilme()
        {
            InitializeComponent();
            lstVFilmes.Columns.Add("ID", 30);
            lstVFilmes.Columns.Add("GENERO", 70);
            lstVFilmes.Columns.Add("TÍTULO", 150);
            lstVFilmes.Columns.Add("DESCRIÇÃO", 200);
            lstVFilmes.Columns.Add("DURAÇÃO", 70);
            lstVFilmes.Columns.Add("ANO REALIZAÇÃO", 70);
            carregarList();
            telaInicial();
        }

        /*função utilizada para realizar a contagem de letras do caminho da imagem
        public static string caminhoPalavra(string caminho) {
            string armazenar = "";
            for (int i = 0; i > caminho.Length; i--)
            {
                if (caminho[i].Equals("/"))
                {
                    armazenar += caminho[i];
                }

            }
            return armazenar;
        }*/

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            query = "SELECT MAX(ID_FILME)+1 AS ID FROM TB_FILME";

            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente inserir este Filme?", "Confirma a Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsFilme mObjFilme = new CS_clsFilme();

                try
                {
                    mObjFilme.Id_Filme = autoIncremento(query);
                    mObjFilme.Ano_Realizacao = txtAnoRealizacao.Text;
                    mObjFilme.Duracao_Filme = txtDuracaoFilme.Text;
                    mObjFilme.Genero_Filme = txtGeneroFilme.Text;
                    mObjFilme.NM_Descricao = txtNmDescricao.Text;
                    mObjFilme.Titulo_Filme = txtTituloFilme.Text;
                    mObjFilme.NM_Folder = caminho;
                    
                    string mErro = mObjFilme.inserirFilme();

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
                catch(Exception ex)
                {
                    MessageBox.Show("Erro catastrofico ");
                }
            }

        }

        private void btnAlterarImagem_Click_1(object sender, EventArgs e)
        {
            ofdBuscar.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";

            DialogResult res = ofdBuscar.ShowDialog();

            if (res == DialogResult.OK)
            {
                pbxDadosFilme.Image = Image.FromFile(ofdBuscar.FileName);
                caminho = ofdBuscar.FileName;
                /*Bitmap bmp = new Bitmap(caminho);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, ImageFormat.Bmp);

                byte[] NM_Folder = ms.ToArray();*/

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
            txtIdFilme.Visible = false;
            lblId.Visible = false;
            carregarList();

            btnIncluir.Enabled = true;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            txtAnoRealizacao.Text = "";
            txtDuracaoFilme.Text = "";
            txtGeneroFilme.Text = "";
            txtNmDescricao.Text = "";
            txtTituloFilme.Text = "";
            txtTituloFilme.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.Close();
            gbxDadosFilme.Enabled = true;
            telaInicial();

        }

        public  void carregarList()
        {
            lstVFilmes.Items.Clear();
            CS_clsFilme objFilmes = new CS_clsFilme();
            SqlDataReader dr = objFilmes.getFilmes();

            while (dr.Read())
            {
                ListViewItem lstV = new ListViewItem(dr["ID_FILME"].ToString());
                lstV.SubItems.Add(dr["NM_FILME"].ToString());
                lstV.SubItems.Add(dr["NM_GENERO"].ToString());
                lstV.SubItems.Add(dr["DS_DESCRICAO"].ToString());
                lstV.SubItems.Add(dr["HR_DURACAO"].ToString());
                lstV.SubItems.Add(dr["DT_ANOREALIZACAO"].ToString());
                lstVFilmes.Items.Add(lstV);
            }
        }

        private void fechandoForm(object sender, FormClosedEventArgs e)
        {
        //quando o form estiver fechando ele recebe nulo para ele poder ser instanciado novamente
            frmInserirFilme = null;
        }

        //realiza o teste para ver se o formulário já possue alguma instância, ele realiza uma instância
        public static CS_frmInserirFilme getInstance()
        {

            if (frmInserirFilme == null)
            {
                frmInserirFilme = new CS_frmInserirFilme();
            }

            return (frmInserirFilme);
        }

        private void lstVFilmes_Click(object sender, EventArgs e)
        {
            gbxDadosFilme.Enabled = false;
            foreach (ListViewItem item in lstVFilmes.SelectedItems)
            {

                CS_clsFilme objFilme = new CS_clsFilme();

                objFilme = objFilme.exibirDados(Convert.ToInt32(item.Text));

                txtIdFilme.Text = objFilme.Id_Filme.ToString();
                txtTituloFilme.Text = objFilme.Titulo_Filme;
                txtDuracaoFilme.Text = objFilme.Duracao_Filme;
                txtAnoRealizacao.Text = objFilme.Ano_Realizacao;
                txtGeneroFilme.Text = objFilme.Genero_Filme;
                txtNmDescricao.Text = objFilme.NM_Descricao;
                pbxDadosFilme.Image = Image.FromFile(objFilme.NM_Folder);

                btnAlterar.Enabled = true;
                btnIncluir.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gbxDadosFilme.Enabled = true;
            txtTituloFilme.Focus();
            btnSalvar.Enabled = true;
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja realmente atualizar este Filme?", "Confirma a Inserção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (iResposta.ToString() == "Yes")
            {
                CS_clsFilme mObjFilme = new CS_clsFilme();

                try
                {
                    mObjFilme.Id_Filme = Convert.ToInt32(txtIdFilme.Text);
                    mObjFilme.Ano_Realizacao = txtAnoRealizacao.Text;
                    mObjFilme.Duracao_Filme = txtDuracaoFilme.Text;
                    mObjFilme.Genero_Filme = txtGeneroFilme.Text;
                    mObjFilme.NM_Descricao = txtNmDescricao.Text;
                    mObjFilme.Titulo_Filme = txtTituloFilme.Text;
                    if (mObjFilme.NM_Folder == null)
                    {
                        mObjFilme.NM_Folder = caminho;
                    }
                    else
                    {
                        mObjFilme.NM_Folder = mObjFilme.NM_Folder;
                    }
                    

                    string mErro = mObjFilme.atualizarFilme();

                    if (mErro == null)
                    {
                        MessageBox.Show("Filme atualizado com sucesso");
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

        private void lstVFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void gbxDadosFilme_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
