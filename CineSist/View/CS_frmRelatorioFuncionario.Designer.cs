namespace CineSist
{
    partial class CS_frmRelatorioFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS_frmRelatorioFuncionario));
            this.TB_FuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_CinesistDataSet1 = new CineSist.BD_CinesistDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TB_FuncionarioTableAdapter = new CineSist.BD_CinesistDataSet1TableAdapters.TB_FuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TB_FuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_FuncionarioBindingSource
            // 
            this.TB_FuncionarioBindingSource.DataMember = "TB_Funcionario";
            this.TB_FuncionarioBindingSource.DataSource = this.BD_CinesistDataSet1;
            // 
            // BD_CinesistDataSet1
            // 
            this.BD_CinesistDataSet1.DataSetName = "BD_CinesistDataSet1";
            this.BD_CinesistDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TB_FuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CineSist.repFuncionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(841, 486);
            this.reportViewer1.TabIndex = 0;
            // 
            // TB_FuncionarioTableAdapter
            // 
            this.TB_FuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // CS_frmRelatorioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CS_frmRelatorioFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Funcionário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CS_frmRelatorioFuncionario_FormClosed);
            this.Load += new System.EventHandler(this.CS_frmRelatorioFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TB_FuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_CinesistDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TB_FuncionarioBindingSource;
        private BD_CinesistDataSet1 BD_CinesistDataSet1;
        private BD_CinesistDataSet1TableAdapters.TB_FuncionarioTableAdapter TB_FuncionarioTableAdapter;
    }
}