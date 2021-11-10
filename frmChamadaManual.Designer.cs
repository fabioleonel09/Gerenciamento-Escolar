namespace GestaoEscolarSistemasLua
{
    partial class frmChamadaManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamadaManual));
            this.GestaoEscolarPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestaoEscolarSistemasLuaDataSet = new GestaoEscolarSistemasLua.GestaoEscolarSistemasLuaDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GestaoEscolarPrincipalTableAdapter = new GestaoEscolarSistemasLua.GestaoEscolarSistemasLuaDataSetTableAdapters.GestaoEscolarPrincipalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarSistemasLuaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GestaoEscolarPrincipalBindingSource
            // 
            this.GestaoEscolarPrincipalBindingSource.DataMember = "GestaoEscolarPrincipal";
            this.GestaoEscolarPrincipalBindingSource.DataSource = this.GestaoEscolarSistemasLuaDataSet;
            // 
            // GestaoEscolarSistemasLuaDataSet
            // 
            this.GestaoEscolarSistemasLuaDataSet.DataSetName = "GestaoEscolarSistemasLuaDataSet";
            this.GestaoEscolarSistemasLuaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 560);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Chamada";
            reportDataSource1.Value = this.GestaoEscolarPrincipalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestaoEscolarSistemasLua.rpChamadaManual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(494, 560);
            this.reportViewer1.TabIndex = 0;
            // 
            // GestaoEscolarPrincipalTableAdapter
            // 
            this.GestaoEscolarPrincipalTableAdapter.ClearBeforeFill = true;
            // 
            // frmChamadaManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 560);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChamadaManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamada Manual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChamadaManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarSistemasLuaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GestaoEscolarPrincipalBindingSource;
        private GestaoEscolarSistemasLuaDataSet GestaoEscolarSistemasLuaDataSet;
        private GestaoEscolarSistemasLuaDataSetTableAdapters.GestaoEscolarPrincipalTableAdapter GestaoEscolarPrincipalTableAdapter;
    }
}