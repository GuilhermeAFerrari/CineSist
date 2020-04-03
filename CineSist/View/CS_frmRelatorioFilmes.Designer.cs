namespace CineSist
{
    partial class CS_frmRelatorioFilmes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmRelatorioFilmes));
            this.BD_CinesistDataSet1 = new CineSist.BD_CinesistDataSet1();
            this.TB_FilmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TB_FilmeTableAdapter = new CineSist.BD_CinesistDataSet1TableAdapters.TB_FilmeTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FilmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BD_CinesistDataSet1
            // 
            this.BD_CinesistDataSet1.DataSetName = "BD_CinesistDataSet1";
            this.BD_CinesistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TB_FilmeBindingSource
            // 
            this.TB_FilmeBindingSource.DataMember = "TB_Filme";
            this.TB_FilmeBindingSource.DataSource = this.BD_CinesistDataSet1;
            // 
            // TB_FilmeTableAdapter
            // 
            this.TB_FilmeTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TB_FilmeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineSist.repFilmes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(841, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // CS_frmRelatorioFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CS_frmRelatorioFilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Filmes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CS_frmRelatorioFilmes_FormClosed);
            this.Load += new System.EventHandler(this.CS_frmRelatorioFilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FilmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource TB_FilmeBindingSource;
        private BD_CinesistDataSet1 BD_CinesistDataSet1;
        private BD_CinesistDataSet1TableAdapters.TB_FilmeTableAdapter TB_FilmeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}