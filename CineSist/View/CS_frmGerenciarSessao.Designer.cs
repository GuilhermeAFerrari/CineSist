namespace CineSist
{
    partial class CS_frmInserirSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmInserirSessao));
            this.gbxDadosSessao = new System.Windows.Forms.GroupBox();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.Sala = new System.Windows.Forms.Label();
            this.cmbFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstVSessao = new System.Windows.Forms.ListView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtValorInteira = new System.Windows.Forms.TextBox();
            this.txtValorMeia = new System.Windows.Forms.TextBox();
            this.lblValorInteira = new System.Windows.Forms.Label();
            this.lblValorMeia = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpSessao = new System.Windows.Forms.DateTimePicker();
            this.cmbFilme = new System.Windows.Forms.ComboBox();
            this.lblFilme = new System.Windows.Forms.Label();
            this.txtIdSessao = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.gbxAcessoSessao = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInativar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbxDadosSessao.SuspendLayout();
            this.gbxAcessoSessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDadosSessao
            // 
            this.gbxDadosSessao.BackColor = System.Drawing.SystemColors.Window;
            this.gbxDadosSessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDadosSessao.Controls.Add(this.cmbSala);
            this.gbxDadosSessao.Controls.Add(this.Sala);
            this.gbxDadosSessao.Controls.Add(this.cmbFuncionario);
            this.gbxDadosSessao.Controls.Add(this.label1);
            this.gbxDadosSessao.Controls.Add(this.lstVSessao);
            this.gbxDadosSessao.Controls.Add(this.cmbStatus);
            this.gbxDadosSessao.Controls.Add(this.lblStatus);
            this.gbxDadosSessao.Controls.Add(this.txtValorInteira);
            this.gbxDadosSessao.Controls.Add(this.txtValorMeia);
            this.gbxDadosSessao.Controls.Add(this.lblValorInteira);
            this.gbxDadosSessao.Controls.Add(this.lblValorMeia);
            this.gbxDadosSessao.Controls.Add(this.cmbHora);
            this.gbxDadosSessao.Controls.Add(this.lblHora);
            this.gbxDadosSessao.Controls.Add(this.dtpSessao);
            this.gbxDadosSessao.Controls.Add(this.cmbFilme);
            this.gbxDadosSessao.Controls.Add(this.lblFilme);
            this.gbxDadosSessao.Controls.Add(this.txtIdSessao);
            this.gbxDadosSessao.Controls.Add(this.lblId);
            this.gbxDadosSessao.Controls.Add(this.lblData);
            this.gbxDadosSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosSessao.Location = new System.Drawing.Point(124, 1);
            this.gbxDadosSessao.Name = "gbxDadosSessao";
            this.gbxDadosSessao.Size = new System.Drawing.Size(721, 484);
            this.gbxDadosSessao.TabIndex = 11;
            this.gbxDadosSessao.TabStop = false;
            this.gbxDadosSessao.Text = "Dados Sessao";
            this.gbxDadosSessao.Enter += new System.EventHandler(this.gbxDadosFilme_Enter);
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSala.Location = new System.Drawing.Point(412, 169);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 29);
            this.cmbSala.TabIndex = 27;
            // 
            // Sala
            // 
            this.Sala.AutoSize = true;
            this.Sala.BackColor = System.Drawing.Color.Transparent;
            this.Sala.Location = new System.Drawing.Point(358, 172);
            this.Sala.Name = "Sala";
            this.Sala.Size = new System.Drawing.Size(42, 21);
            this.Sala.TabIndex = 28;
            this.Sala.Text = "Sala:";
            // 
            // cmbFuncionario
            // 
            this.cmbFuncionario.FormattingEnabled = true;
            this.cmbFuncionario.Location = new System.Drawing.Point(412, 221);
            this.cmbFuncionario.Name = "cmbFuncionario";
            this.cmbFuncionario.Size = new System.Drawing.Size(208, 29);
            this.cmbFuncionario.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(314, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Funcionário";
            // 
            // lstVSessao
            // 
            this.lstVSessao.Location = new System.Drawing.Point(17, 280);
            this.lstVSessao.Name = "lstVSessao";
            this.lstVSessao.Size = new System.Drawing.Size(682, 198);
            this.lstVSessao.TabIndex = 7;
            this.lstVSessao.UseCompatibleStateImageBehavior = false;
            this.lstVSessao.View = System.Windows.Forms.View.Details;
            this.lstVSessao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstVSessao_MouseClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Aberta",
            "Em Andamento",
            "Encerrada"});
            this.cmbStatus.Location = new System.Drawing.Point(412, 64);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(153, 29);
            this.cmbStatus.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(346, 67);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 21);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status:";
            // 
            // txtValorInteira
            // 
            this.txtValorInteira.Location = new System.Drawing.Point(193, 174);
            this.txtValorInteira.Name = "txtValorInteira";
            this.txtValorInteira.Size = new System.Drawing.Size(100, 29);
            this.txtValorInteira.TabIndex = 5;
            // 
            // txtValorMeia
            // 
            this.txtValorMeia.Location = new System.Drawing.Point(193, 221);
            this.txtValorMeia.Name = "txtValorMeia";
            this.txtValorMeia.Size = new System.Drawing.Size(100, 29);
            this.txtValorMeia.TabIndex = 6;
            // 
            // lblValorInteira
            // 
            this.lblValorInteira.AutoSize = true;
            this.lblValorInteira.BackColor = System.Drawing.Color.Transparent;
            this.lblValorInteira.Location = new System.Drawing.Point(13, 177);
            this.lblValorInteira.Name = "lblValorInteira";
            this.lblValorInteira.Size = new System.Drawing.Size(170, 21);
            this.lblValorInteira.TabIndex = 21;
            this.lblValorInteira.Text = "Valor Ingresso - Inteira:";
            // 
            // lblValorMeia
            // 
            this.lblValorMeia.AutoSize = true;
            this.lblValorMeia.BackColor = System.Drawing.Color.Transparent;
            this.lblValorMeia.Location = new System.Drawing.Point(13, 227);
            this.lblValorMeia.Name = "lblValorMeia";
            this.lblValorMeia.Size = new System.Drawing.Size(160, 21);
            this.lblValorMeia.TabIndex = 20;
            this.lblValorMeia.Text = "Valor Ingresso - Meia:";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Items.AddRange(new object[] {
            "16:00",
            "18:00",
            "20:30"});
            this.cmbHora.Location = new System.Drawing.Point(412, 114);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(121, 29);
            this.cmbHora.TabIndex = 4;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Location = new System.Drawing.Point(358, 117);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 21);
            this.lblHora.TabIndex = 18;
            this.lblHora.Text = "Hora:";
            // 
            // dtpSessao
            // 
            this.dtpSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSessao.Location = new System.Drawing.Point(70, 114);
            this.dtpSessao.Name = "dtpSessao";
            this.dtpSessao.Size = new System.Drawing.Size(104, 29);
            this.dtpSessao.TabIndex = 3;
            this.dtpSessao.Value = new System.DateTime(2018, 11, 1, 20, 30, 57, 0);
            // 
            // cmbFilme
            // 
            this.cmbFilme.FormattingEnabled = true;
            this.cmbFilme.Location = new System.Drawing.Point(70, 64);
            this.cmbFilme.Name = "cmbFilme";
            this.cmbFilme.Size = new System.Drawing.Size(208, 29);
            this.cmbFilme.TabIndex = 1;
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.BackColor = System.Drawing.Color.Transparent;
            this.lblFilme.Location = new System.Drawing.Point(13, 67);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(51, 21);
            this.lblFilme.TabIndex = 14;
            this.lblFilme.Text = "Filme:";
            // 
            // txtIdSessao
            // 
            this.txtIdSessao.Location = new System.Drawing.Point(597, 25);
            this.txtIdSessao.Name = "txtIdSessao";
            this.txtIdSessao.Size = new System.Drawing.Size(59, 29);
            this.txtIdSessao.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(561, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Location = new System.Drawing.Point(12, 120);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 21);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data:";
            // 
            // gbxAcessoSessao
            // 
            this.gbxAcessoSessao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxAcessoSessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxAcessoSessao.Controls.Add(this.btnSalvar);
            this.gbxAcessoSessao.Controls.Add(this.btnCancelar);
            this.gbxAcessoSessao.Controls.Add(this.btnInativar);
            this.gbxAcessoSessao.Controls.Add(this.btnAlterar);
            this.gbxAcessoSessao.Controls.Add(this.btnIncluir);
            this.gbxAcessoSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAcessoSessao.Location = new System.Drawing.Point(2, 1);
            this.gbxAcessoSessao.Name = "gbxAcessoSessao";
            this.gbxAcessoSessao.Size = new System.Drawing.Size(123, 484);
            this.gbxAcessoSessao.TabIndex = 12;
            this.gbxAcessoSessao.TabStop = false;
            this.gbxAcessoSessao.Text = "Acesso Sessao";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(14, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 76);
            this.btnSalvar.TabIndex = 11;
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
            this.btnCancelar.Location = new System.Drawing.Point(14, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 76);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInativar
            // 
            this.btnInativar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInativar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInativar.BackgroundImage")));
            this.btnInativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInativar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInativar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInativar.Location = new System.Drawing.Point(15, 153);
            this.btnInativar.Name = "btnInativar";
            this.btnInativar.Size = new System.Drawing.Size(82, 76);
            this.btnInativar.TabIndex = 9;
            this.btnInativar.Text = "I&nativar";
            this.btnInativar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInativar.UseVisualStyleBackColor = false;
            this.btnInativar.Click += new System.EventHandler(this.btnInativar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(15, 237);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(82, 76);
            this.btnAlterar.TabIndex = 10;
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
            this.btnIncluir.Location = new System.Drawing.Point(14, 67);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(84, 76);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // CS_frmInserirSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 490);
            this.Controls.Add(this.gbxAcessoSessao);
            this.Controls.Add(this.gbxDadosSessao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CS_frmInserirSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Sessão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fechandoForm);
            this.gbxDadosSessao.ResumeLayout(false);
            this.gbxDadosSessao.PerformLayout();
            this.gbxAcessoSessao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosSessao;
        private System.Windows.Forms.TextBox txtIdSessao;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox gbxAcessoSessao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInativar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpSessao;
        private System.Windows.Forms.ComboBox cmbFilme;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtValorInteira;
        private System.Windows.Forms.TextBox txtValorMeia;
        private System.Windows.Forms.Label lblValorInteira;
        private System.Windows.Forms.Label lblValorMeia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListView lstVSessao;
        private System.Windows.Forms.ComboBox cmbFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label Sala;
    }
}