namespace CineSist
{
    partial class CS_frmRelatorioSessoes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmRelatorioSessoes));
            this.TB_SessaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_CinesistDataSet1 = new CineSist.BD_CinesistDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TB_SessaoTableAdapter = new CineSist.BD_CinesistDataSet1TableAdapters.TB_SessaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TB_SessaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_SessaoBindingSource
            // 
            this.TB_SessaoBindingSource.DataMember = "TB_Sessao";
            this.TB_SessaoBindingSource.DataSource = this.BD_CinesistDataSet1;
            // 
            // BD_CinesistDataSet1
            // 
            this.BD_CinesistDataSet1.DataSetName = "BD_CinesistDataSet1";
            this.BD_CinesistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TB_SessaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineSist.repSessoes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(841, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // TB_SessaoTableAdapter
            // 
            this.TB_SessaoTableAdapter.ClearBeforeFill = true;
            // 
            // CS_frmRelatorioSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CS_frmRelatorioSessoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Sessões";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CS_frmRelatorioSessoes_FormClosed);
            this.Load += new System.EventHandler(this.CS_frmRelatorioSessoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_SessaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TB_SessaoBindingSource;
        private BD_CinesistDataSet1 BD_CinesistDataSet1;
        private BD_CinesistDataSet1TableAdapters.TB_SessaoTableAdapter TB_SessaoTableAdapter;
    }
}