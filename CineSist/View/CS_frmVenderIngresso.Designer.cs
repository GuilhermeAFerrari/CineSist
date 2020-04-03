namespace CineSist
{
    partial class CS_frmVenderIngresso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmVenderIngresso));
            this.gbxVenderIngresso = new System.Windows.Forms.GroupBox();
            this.lstVIngresso = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.gbxSessao = new System.Windows.Forms.GroupBox();
            this.txtIdSessao = new System.Windows.Forms.TextBox();
            this.lstVSessao = new System.Windows.Forms.ListView();
            this.gbxVenderIngresso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxSessao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxVenderIngresso
            // 
            this.gbxVenderIngresso.Controls.Add(this.lstVIngresso);
            this.gbxVenderIngresso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVenderIngresso.Location = new System.Drawing.Point(136, 3);
            this.gbxVenderIngresso.Name = "gbxVenderIngresso";
            this.gbxVenderIngresso.Size = new System.Drawing.Size(703, 191);
            this.gbxVenderIngresso.TabIndex = 1;
            this.gbxVenderIngresso.TabStop = false;
            this.gbxVenderIngresso.Text = "Dados Ingresso";
            this.gbxVenderIngresso.Enter += new System.EventHandler(this.gbxVenderIngresso_Enter);
            // 
            // lstVIngresso
            // 
            this.lstVIngresso.Location = new System.Drawing.Point(22, 40);
            this.lstVIngresso.Name = "lstVIngresso";
            this.lstVIngresso.Size = new System.Drawing.Size(652, 134);
            this.lstVIngresso.TabIndex = 1;
            this.lstVIngresso.UseCompatibleStateImageBehavior = false;
            this.lstVIngresso.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnCancelarVenda);
            this.groupBox1.Controls.Add(this.btnConcluirVenda);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 483);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Ingresso";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarVenda.BackgroundImage")));
            this.btnCancelarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarVenda.Location = new System.Drawing.Point(10, 175);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(102, 93);
            this.btnCancelarVenda.TabIndex = 14;
            this.btnCancelarVenda.Text = "C&ancelar Venda";
            this.btnCancelarVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConcluirVenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConcluirVenda.BackgroundImage")));
            this.btnConcluirVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluirVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConcluirVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConcluirVenda.Location = new System.Drawing.Point(10, 61);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(102, 93);
            this.btnConcluirVenda.TabIndex = 13;
            this.btnConcluirVenda.Text = "&Concluir Venda";
            this.btnConcluirVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConcluirVenda.UseVisualStyleBackColor = false;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // gbxSessao
            // 
            this.gbxSessao.Controls.Add(this.txtIdSessao);
            this.gbxSessao.Controls.Add(this.lstVSessao);
            this.gbxSessao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSessao.Location = new System.Drawing.Point(136, 200);
            this.gbxSessao.Name = "gbxSessao";
            this.gbxSessao.Size = new System.Drawing.Size(703, 198);
            this.gbxSessao.TabIndex = 2;
            this.gbxSessao.TabStop = false;
            this.gbxSessao.Text = "Dados Sessões";
            // 
            // txtIdSessao
            // 
            this.txtIdSessao.Location = new System.Drawing.Point(593, 163);
            this.txtIdSessao.Name = "txtIdSessao";
            this.txtIdSessao.Size = new System.Drawing.Size(81, 29);
            this.txtIdSessao.TabIndex = 3;
            // 
            // lstVSessao
            // 
            this.lstVSessao.Location = new System.Drawing.Point(22, 40);
            this.lstVSessao.Name = "lstVSessao";
            this.lstVSessao.Size = new System.Drawing.Size(652, 122);
            this.lstVSessao.TabIndex = 1;
            this.lstVSessao.UseCompatibleStateImageBehavior = false;
            this.lstVSessao.View = System.Windows.Forms.View.Details;
            this.lstVSessao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstVSessao_MouseClick);
            // 
            // CS_frmVenderIngresso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.gbxSessao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxVenderIngresso);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CS_frmVenderIngresso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de Ingresso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fechandoForm);
            this.Click += new System.EventHandler(this.CS_frmVenderIngresso_Click);
            this.gbxVenderIngresso.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbxSessao.ResumeLayout(false);
            this.gbxSessao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxVenderIngresso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstVIngresso;
        private System.Windows.Forms.GroupBox gbxSessao;
        private System.Windows.Forms.ListView lstVSessao;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnConcluirVenda;
        public System.Windows.Forms.TextBox txtIdSessao;
    }
}