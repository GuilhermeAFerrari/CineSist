namespace CineSist
{
    partial class CS_frmGerenciarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmGerenciarFuncionario));
            this.gbxDadosFuncionario = new System.Windows.Forms.GroupBox();
            this.lstVFuncionario = new System.Windows.Forms.ListView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIdFuncionario = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbxAcessoSessao = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.gbxDadosFuncionario.SuspendLayout();
            this.gbxAcessoSessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDadosFuncionario
            // 
            this.gbxDadosFuncionario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDadosFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxDadosFuncionario.Controls.Add(this.lstVFuncionario);
            this.gbxDadosFuncionario.Controls.Add(this.txtEmail);
            this.gbxDadosFuncionario.Controls.Add(this.lblEmail);
            this.gbxDadosFuncionario.Controls.Add(this.cmbSexo);
            this.gbxDadosFuncionario.Controls.Add(this.lblSexo);
            this.gbxDadosFuncionario.Controls.Add(this.cmbCargo);
            this.gbxDadosFuncionario.Controls.Add(this.lblCargo);
            this.gbxDadosFuncionario.Controls.Add(this.txtRg);
            this.gbxDadosFuncionario.Controls.Add(this.lblRg);
            this.gbxDadosFuncionario.Controls.Add(this.txtCpf);
            this.gbxDadosFuncionario.Controls.Add(this.lblCpf);
            this.gbxDadosFuncionario.Controls.Add(this.txtNome);
            this.gbxDadosFuncionario.Controls.Add(this.lblNome);
            this.gbxDadosFuncionario.Controls.Add(this.txtIdFuncionario);
            this.gbxDadosFuncionario.Controls.Add(this.lblId);
            this.gbxDadosFuncionario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosFuncionario.Location = new System.Drawing.Point(124, 2);
            this.gbxDadosFuncionario.Name = "gbxDadosFuncionario";
            this.gbxDadosFuncionario.Size = new System.Drawing.Size(715, 525);
            this.gbxDadosFuncionario.TabIndex = 16;
            this.gbxDadosFuncionario.TabStop = false;
            this.gbxDadosFuncionario.Text = "Dados Funcionario";
            // 
            // lstVFuncionario
            // 
            this.lstVFuncionario.Location = new System.Drawing.Point(29, 277);
            this.lstVFuncionario.Name = "lstVFuncionario";
            this.lstVFuncionario.Size = new System.Drawing.Size(653, 197);
            this.lstVFuncionario.TabIndex = 7;
            this.lstVFuncionario.UseCompatibleStateImageBehavior = false;
            this.lstVFuncionario.View = System.Windows.Forms.View.Details;
            this.lstVFuncionario.Click += new System.EventHandler(this.lstVFuncionario_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(248, 29);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(5, 203);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 21);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "E-mail:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(404, 153);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(182, 29);
            this.cmbSexo.TabIndex = 5;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Location = new System.Drawing.Point(348, 156);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 21);
            this.lblSexo.TabIndex = 22;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Gerente",
            "Atendente"});
            this.cmbCargo.Location = new System.Drawing.Point(70, 153);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(193, 29);
            this.cmbCargo.TabIndex = 4;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Location = new System.Drawing.Point(6, 156);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(55, 21);
            this.lblCargo.TabIndex = 20;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(404, 107);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(182, 29);
            this.txtRg.TabIndex = 3;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.BackColor = System.Drawing.Color.Transparent;
            this.lblRg.Location = new System.Drawing.Point(361, 111);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(34, 21);
            this.lblRg.TabIndex = 18;
            this.lblRg.Text = "RG:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(70, 108);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(193, 29);
            this.txtCpf.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Location = new System.Drawing.Point(18, 111);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 21);
            this.lblCpf.TabIndex = 16;
            this.lblCpf.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(516, 29);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Location = new System.Drawing.Point(8, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 21);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome:";
            // 
            // txtIdFuncionario
            // 
            this.txtIdFuncionario.Location = new System.Drawing.Point(623, 25);
            this.txtIdFuncionario.Name = "txtIdFuncionario";
            this.txtIdFuncionario.Size = new System.Drawing.Size(59, 29);
            this.txtIdFuncionario.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Location = new System.Drawing.Point(588, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 21);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // gbxAcessoSessao
            // 
            this.gbxAcessoSessao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxAcessoSessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxAcessoSessao.Controls.Add(this.btnSalvar);
            this.gbxAcessoSessao.Controls.Add(this.btnCancelar);
            this.gbxAcessoSessao.Controls.Add(this.btnAlterar);
            this.gbxAcessoSessao.Controls.Add(this.btnIncluir);
            this.gbxAcessoSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAcessoSessao.Location = new System.Drawing.Point(2, 2);
            this.gbxAcessoSessao.Name = "gbxAcessoSessao";
            this.gbxAcessoSessao.Size = new System.Drawing.Size(123, 525);
            this.gbxAcessoSessao.TabIndex = 27;
            this.gbxAcessoSessao.TabStop = false;
            this.gbxAcessoSessao.Text = "Acesso Funcionário";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(15, 234);
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
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(15, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 76);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(16, 149);
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
            this.btnIncluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // CS_frmGerenciarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 490);
            this.Controls.Add(this.gbxAcessoSessao);
            this.Controls.Add(this.gbxDadosFuncionario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CS_frmGerenciarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Funcionário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fechandoForm);
            this.gbxDadosFuncionario.ResumeLayout(false);
            this.gbxDadosFuncionario.PerformLayout();
            this.gbxAcessoSessao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDadosFuncionario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIdFuncionario;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListView lstVFuncionario;
        private System.Windows.Forms.GroupBox gbxAcessoSessao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
    }
}