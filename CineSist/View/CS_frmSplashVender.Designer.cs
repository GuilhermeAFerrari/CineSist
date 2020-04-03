namespace CineSist
{
    partial class CS_frmSplashVender
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
            this.pgbImprimir = new System.Windows.Forms.ProgressBar();
            this.lblImprimindo = new System.Windows.Forms.Label();
            this.gbxImprimindo = new System.Windows.Forms.GroupBox();
            this.tmpImprimir = new System.Windows.Forms.Timer(this.components);
            this.gbxImprimindo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgbImprimir
            // 
            this.pgbImprimir.Location = new System.Drawing.Point(38, 39);
            this.pgbImprimir.Name = "pgbImprimir";
            this.pgbImprimir.Size = new System.Drawing.Size(158, 25);
            this.pgbImprimir.TabIndex = 0;
            // 
            // lblImprimindo
            // 
            this.lblImprimindo.AutoSize = true;
            this.lblImprimindo.Location = new System.Drawing.Point(71, 78);
            this.lblImprimindo.Name = "lblImprimindo";
            this.lblImprimindo.Size = new System.Drawing.Size(93, 17);
            this.lblImprimindo.TabIndex = 1;
            this.lblImprimindo.Text = "Imprimindo...";
            // 
            // gbxImprimindo
            // 
            this.gbxImprimindo.Controls.Add(this.pgbImprimir);
            this.gbxImprimindo.Controls.Add(this.lblImprimindo);
            this.gbxImprimindo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxImprimindo.Location = new System.Drawing.Point(21, 23);
            this.gbxImprimindo.Name = "gbxImprimindo";
            this.gbxImprimindo.Size = new System.Drawing.Size(238, 120);
            this.gbxImprimindo.TabIndex = 2;
            this.gbxImprimindo.TabStop = false;
            // 
            // tmpImprimir
            // 
            this.tmpImprimir.Enabled = true;
            this.tmpImprimir.Tick += new System.EventHandler(this.tmpImprimir_Tick);
            // 
            // CS_frmSplashVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.ControlBox = false;
            this.Controls.Add(this.gbxImprimindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CS_frmSplashVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS_frmSplashVender";
            this.gbxImprimindo.ResumeLayout(false);
            this.gbxImprimindo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbImprimir;
        private System.Windows.Forms.Label lblImprimindo;
        private System.Windows.Forms.GroupBox gbxImprimindo;
        private System.Windows.Forms.Timer tmpImprimir;
    }
}