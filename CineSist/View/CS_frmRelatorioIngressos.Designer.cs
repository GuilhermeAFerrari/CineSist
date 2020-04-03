namespace CineSist
{
    partial class CS_frmRelatorioIngressos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmRelatorioIngressos));
            this.vendaIngressoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_CinesistDataSet2 = new CineSist.BD_CinesistDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vendaIngressoTableAdapter = new CineSist.BD_CinesistDataSet2TableAdapters.vendaIngressoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendaIngressoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // vendaIngressoBindingSource
            // 
            this.vendaIngressoBindingSource.DataMember = "vendaIngresso";
            this.vendaIngressoBindingSource.DataSource = this.BD_CinesistDataSet2;
            // 
            // BD_CinesistDataSet2
            // 
            this.BD_CinesistDataSet2.DataSetName = "BD_CinesistDataSet2";
            this.BD_CinesistDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vendaIngressoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineSist.ingressoVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(841, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // vendaIngressoTableAdapter
            // 
            this.vendaIngressoTableAdapter.ClearBeforeFill = true;
            // 
            // CS_frmRelatorioIngressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CS_frmRelatorioIngressos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Ingressos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CS_frmRelatorioIngressos_FormClosed);
            this.Load += new System.EventHandler(this.CS_frmRelatorioIngressos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaIngressoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vendaIngressoBindingSource;
        private BD_CinesistDataSet2 BD_CinesistDataSet2;
        private BD_CinesistDataSet2TableAdapters.vendaIngressoTableAdapter vendaIngressoTableAdapter;
    }
}