namespace CineSist
{
    partial class CS_frmInserirFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmInserirFilme));
            this.gbxAcessoFilme = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbxDadosFilme = new System.Windows.Forms.GroupBox();
            this.lstVFilmes = new System.Windows.Forms.ListView();
            this.btnAlterarImagem = new System.Windows.Forms.Button();
            this.pbxDadosFilme = new System.Windows.Forms.PictureBox();
            this.txtAnoRealizacao = new System.Windows.Forms.TextBox();
            this.txtNmDescricao = new System.Windows.Forms.TextBox();
            this.txtGeneroFilme = new System.Windows.Forms.TextBox();
            this.txtDuracaoFilme = new System.Windows.Forms.TextBox();
            this.txtTituloFilme = new System.Windows.Forms.TextBox();
            this.txtIdFilme = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAnoRealizacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.bDCinesistDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_CinesistDataSet = new CineSist.DataBase.BD_CinesistDataSet();
            this.cineSistDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofdBuscar = new System.Windows.Forms.OpenFileDialog();
            this.bDCinesistDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxAcessoFilme.SuspendLayout();
            this.gbxDadosFilme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDadosFilme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCinesistDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_CinesistDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineSistDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCinesistDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAcessoFilme
            // 
            this.gbxAcessoFilme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxAcessoFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxAcessoFilme.Controls.Add(this.btnSalvar);
            this.gbxAcessoFilme.Controls.Add(this.btnCancelar);
            this.gbxAcessoFilme.Controls.Add(this.btnAlterar);
            this.gbxAcessoFilme.Controls.Add(this.btnIncluir);
            this.gbxAcessoFilme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAcessoFilme.Location = new System.Drawing.Point(3, 3);
            this.gbxAcessoFilme.Name = "gbxAcessoFilme";
            this.gbxAcessoFilme.Size = new System.Drawing.Size(127, 483);
            this.gbxAcessoFilme.TabIndex = 11;
            this.gbxAcessoFilme.TabStop = false;
            this.gbxAcessoFilme.Text = "Acesso Filme";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(14, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 70);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(14, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 70);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(15, 132);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 70);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(14, 54);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(84, 70);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click_1);
            // 
            // gbxDadosFilme
            // 
            this.gbxDadosFilme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxDadosFilme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDadosFilme.Controls.Add(this.lstVFilmes);
            this.gbxDadosFilme.Controls.Add(this.btnAlterarImagem);
            this.gbxDadosFilme.Controls.Add(this.pbxDadosFilme);
            this.gbxDadosFilme.Controls.Add(this.txtAnoRealizacao);
            this.gbxDadosFilme.Controls.Add(this.txtNmDescricao);
            this.gbxDadosFilme.Controls.Add(this.txtGeneroFilme);
            this.gbxDadosFilme.Controls.Add(this.txtDuracaoFilme);
            this.gbxDadosFilme.Controls.Add(this.txtTituloFilme);
            this.gbxDadosFilme.Controls.Add(this.txtIdFilme);
            this.gbxDadosFilme.Controls.Add(this.lblId);
            this.gbxDadosFilme.Controls.Add(this.lblAnoRealizacao);
            this.gbxDadosFilme.Controls.Add(this.lblTitulo);
            this.gbxDadosFilme.Controls.Add(this.lblGenero);
            this.gbxDadosFilme.Controls.Add(this.lblDescricao);
            this.gbxDadosFilme.Controls.Add(this.lblDuracao);
            this.gbxDadosFilme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosFilme.Location = new System.Drawing.Point(130, 2);
            this.gbxDadosFilme.Name = "gbxDadosFilme";
            this.gbxDadosFilme.Size = new System.Drawing.Size(712, 484);
            this.gbxDadosFilme.TabIndex = 10;
            this.gbxDadosFilme.TabStop = false;
            this.gbxDadosFilme.Text = "Dados Filme";
            this.gbxDadosFilme.Enter += new System.EventHandler(this.gbxDadosFilme_Enter);
            // 
            // lstVFilmes
            // 
            this.lstVFilmes.Location = new System.Drawing.Point(17, 292);
            this.lstVFilmes.Name = "lstVFilmes";
            this.lstVFilmes.Size = new System.Drawing.Size(647, 177);
            this.lstVFilmes.TabIndex = 13;
            this.lstVFilmes.UseCompatibleStateImageBehavior = false;
            this.lstVFilmes.View = System.Windows.Forms.View.Details;
            this.lstVFilmes.SelectedIndexChanged += new System.EventHandler(this.lstVFilmes_SelectedIndexChanged);
            this.lstVFilmes.Click += new System.EventHandler(this.lstVFilmes_Click);
            // 
            // btnAlterarImagem
            // 
            this.btnAlterarImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarImagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarImagem.Location = new System.Drawing.Point(517, 198);
            this.btnAlterarImagem.Name = "btnAlterarImagem";
            this.btnAlterarImagem.Size = new System.Drawing.Size(138, 35);
            this.btnAlterarImagem.TabIndex = 6;
            this.btnAlterarImagem.Text = "Alterar Imagem";
            this.btnAlterarImagem.UseVisualStyleBackColor = true;
            this.btnAlterarImagem.Click += new System.EventHandler(this.btnAlterarImagem_Click_1);
            // 
            // pbxDadosFilme
            // 
            this.pbxDadosFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxDadosFilme.Image = ((System.Drawing.Image)(resources.GetObject("pbxDadosFilme.Image")));
            this.pbxDadosFilme.Location = new System.Drawing.Point(506, 28);
            this.pbxDadosFilme.Name = "pbxDadosFilme";
            this.pbxDadosFilme.Size = new System.Drawing.Size(158, 157);
            this.pbxDadosFilme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDadosFilme.TabIndex = 12;
            this.pbxDadosFilme.TabStop = false;
            // 
            // txtAnoRealizacao
            // 
            this.txtAnoRealizacao.Location = new System.Drawing.Point(373, 108);
            this.txtAnoRealizacao.Name = "txtAnoRealizacao";
            this.txtAnoRealizacao.Size = new System.Drawing.Size(96, 29);
            this.txtAnoRealizacao.TabIndex = 3;
            // 
            // txtNmDescricao
            // 
            this.txtNmDescricao.Location = new System.Drawing.Point(93, 198);
            this.txtNmDescricao.Multiline = true;
            this.txtNmDescricao.Name = "txtNmDescricao";
            this.txtNmDescricao.Size = new System.Drawing.Size(376, 85);
            this.txtNmDescricao.TabIndex = 5;
            // 
            // txtGeneroFilme
            // 
            this.txtGeneroFilme.Location = new System.Drawing.Point(93, 154);
            this.txtGeneroFilme.Name = "txtGeneroFilme";
            this.txtGeneroFilme.Size = new System.Drawing.Size(127, 29);
            this.txtGeneroFilme.TabIndex = 4;
            // 
            // txtDuracaoFilme
            // 
            this.txtDuracaoFilme.Location = new System.Drawing.Point(93, 108);
            this.txtDuracaoFilme.Name = "txtDuracaoFilme";
            this.txtDuracaoFilme.Size = new System.Drawing.Size(127, 29);
            this.txtDuracaoFilme.TabIndex = 2;
            // 
            // txtTituloFilme
            // 
            this.txtTituloFilme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloFilme.Location = new System.Drawing.Point(93, 60);
            this.txtTituloFilme.Name = "txtTituloFilme";
            this.txtTituloFilme.Size = new System.Drawing.Size(376, 29);
            this.txtTituloFilme.TabIndex = 1;
            // 
            // txtIdFilme
            // 
            this.txtIdFilme.Location = new System.Drawing.Point(405, 28);
            this.txtIdFilme.Name = "txtIdFilme";
            this.txtIdFilme.Size = new System.Drawing.Size(59, 29);
            this.txtIdFilme.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(369, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblAnoRealizacao
            // 
            this.lblAnoRealizacao.AutoSize = true;
            this.lblAnoRealizacao.BackColor = System.Drawing.Color.Transparent;
            this.lblAnoRealizacao.Location = new System.Drawing.Point(242, 111);
            this.lblAnoRealizacao.Name = "lblAnoRealizacao";
            this.lblAnoRealizacao.Size = new System.Drawing.Size(118, 21);
            this.lblAnoRealizacao.TabIndex = 5;
            this.lblAnoRealizacao.Text = "Ano Realização:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 21);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.Location = new System.Drawing.Point(13, 157);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 21);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Location = new System.Drawing.Point(6, 228);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 21);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.BackColor = System.Drawing.Color.Transparent;
            this.lblDuracao.Location = new System.Drawing.Point(13, 111);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(71, 21);
            this.lblDuracao.TabIndex = 3;
            this.lblDuracao.Text = "Duração:";
            // 
            // bDCinesistDataSetBindingSource1
            // 
            this.bDCinesistDataSetBindingSource1.DataSource = this.bD_CinesistDataSet;
            this.bDCinesistDataSetBindingSource1.Position = 0;
            // 
            // bD_CinesistDataSet
            // 
            this.bD_CinesistDataSet.DataSetName = "BD_CinesistDataSet";
            this.bD_CinesistDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ofdBuscar
            // 
            this.ofdBuscar.FileName = "ofdBuscar";
            // 
            // bDCinesistDataSetBindingSource
            // 
            this.bDCinesistDataSetBindingSource.DataSource = this.bD_CinesistDataSet;
            this.bDCinesistDataSetBindingSource.Position = 0;
            // 
            // CS_frmInserirFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.gbxAcessoFilme);
            this.Controls.Add(this.gbxDadosFilme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CS_frmInserirFilme";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Filme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fechandoForm);
            this.gbxAcessoFilme.ResumeLayout(false);
            this.gbxDadosFilme.ResumeLayout(false);
            this.gbxDadosFilme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDadosFilme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCinesistDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_CinesistDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineSistDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDCinesistDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAcessoFilme;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox gbxDadosFilme;
        private System.Windows.Forms.Button btnAlterarImagem;
        private System.Windows.Forms.PictureBox pbxDadosFilme;
        private System.Windows.Forms.TextBox txtAnoRealizacao;
        private System.Windows.Forms.TextBox txtNmDescricao;
        private System.Windows.Forms.TextBox txtGeneroFilme;
        private System.Windows.Forms.TextBox txtDuracaoFilme;
        private System.Windows.Forms.TextBox txtTituloFilme;
        private System.Windows.Forms.TextBox txtIdFilme;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAnoRealizacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.OpenFileDialog ofdBuscar;
        private System.Windows.Forms.BindingSource cineSistDataSetBindingSource;
        private System.Windows.Forms.BindingSource bDCinesistDataSetBindingSource;
        private DataBase.BD_CinesistDataSet bD_CinesistDataSet;
        private System.Windows.Forms.BindingSource bDCinesistDataSetBindingSource1;
        private System.Windows.Forms.ListView lstVFilmes;
        private System.Windows.Forms.Button btnSalvar;
        //private Model.CineSistDataSet cineSistDataSet;
    }
}