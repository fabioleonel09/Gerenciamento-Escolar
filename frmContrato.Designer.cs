namespace GestaoEscolarSistemasLua
{
    partial class frmContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContrato));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFiltrarContrato = new System.Windows.Forms.GroupBox();
            this.btnFiltrarContrato = new System.Windows.Forms.Button();
            this.txtFiltrarContrato = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbMatricula = new System.Windows.Forms.RadioButton();
            this.GestaoEscolarPrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestaoEscolarSistemasLuaDataSet = new GestaoEscolarSistemasLua.GestaoEscolarSistemasLuaDataSet();
            this.GestaoEscolarPrincipalTableAdapter = new GestaoEscolarSistemasLua.GestaoEscolarSistemasLuaDataSetTableAdapters.GestaoEscolarPrincipalTableAdapter();
            this.panel1.SuspendLayout();
            this.gbFiltrarContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarPrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarSistemasLuaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFiltrarContrato);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 548);
            this.panel1.TabIndex = 0;
            // 
            // gbFiltrarContrato
            // 
            this.gbFiltrarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFiltrarContrato.Controls.Add(this.rbMatricula);
            this.gbFiltrarContrato.Controls.Add(this.rbNome);
            this.gbFiltrarContrato.Controls.Add(this.btnFiltrarContrato);
            this.gbFiltrarContrato.Controls.Add(this.txtFiltrarContrato);
            this.gbFiltrarContrato.Location = new System.Drawing.Point(12, 9);
            this.gbFiltrarContrato.Name = "gbFiltrarContrato";
            this.gbFiltrarContrato.Size = new System.Drawing.Size(784, 82);
            this.gbFiltrarContrato.TabIndex = 1;
            this.gbFiltrarContrato.TabStop = false;
            this.gbFiltrarContrato.Text = "Pesquise o aluno para a impressão do contrato";
            // 
            // btnFiltrarContrato
            // 
            this.btnFiltrarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrarContrato.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFiltrarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarContrato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrarContrato.Image")));
            this.btnFiltrarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrarContrato.Location = new System.Drawing.Point(648, 21);
            this.btnFiltrarContrato.Name = "btnFiltrarContrato";
            this.btnFiltrarContrato.Size = new System.Drawing.Size(130, 49);
            this.btnFiltrarContrato.TabIndex = 1;
            this.btnFiltrarContrato.Text = "Pesquisar";
            this.btnFiltrarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrarContrato.UseVisualStyleBackColor = false;
            this.btnFiltrarContrato.Click += new System.EventHandler(this.btnFiltrarContrato_Click);
            // 
            // txtFiltrarContrato
            // 
            this.txtFiltrarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarContrato.Location = new System.Drawing.Point(6, 33);
            this.txtFiltrarContrato.Name = "txtFiltrarContrato";
            this.txtFiltrarContrato.Size = new System.Drawing.Size(443, 26);
            this.txtFiltrarContrato.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dadosContrato";
            reportDataSource1.Value = this.GestaoEscolarPrincipalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GestaoEscolarSistemasLua.rpContrato.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(808, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // rbNome
            // 
            this.rbNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(491, 21);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(68, 22);
            this.rbNome.TabIndex = 2;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbMatricula
            // 
            this.rbMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMatricula.AutoSize = true;
            this.rbMatricula.Location = new System.Drawing.Point(491, 49);
            this.rbMatricula.Name = "rbMatricula";
            this.rbMatricula.Size = new System.Drawing.Size(88, 22);
            this.rbMatricula.TabIndex = 3;
            this.rbMatricula.TabStop = true;
            this.rbMatricula.Text = "Matrícula";
            this.rbMatricula.UseVisualStyleBackColor = true;
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
            // GestaoEscolarPrincipalTableAdapter
            // 
            this.GestaoEscolarPrincipalTableAdapter.ClearBeforeFill = true;
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 548);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão do contrato";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContrato_Load);
            this.panel1.ResumeLayout(false);
            this.gbFiltrarContrato.ResumeLayout(false);
            this.gbFiltrarContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarPrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestaoEscolarSistemasLuaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GestaoEscolarPrincipalBindingSource;
        private GestaoEscolarSistemasLuaDataSet GestaoEscolarSistemasLuaDataSet;
        private GestaoEscolarSistemasLuaDataSetTableAdapters.GestaoEscolarPrincipalTableAdapter GestaoEscolarPrincipalTableAdapter;
        private System.Windows.Forms.GroupBox gbFiltrarContrato;
        private System.Windows.Forms.Button btnFiltrarContrato;
        private System.Windows.Forms.TextBox txtFiltrarContrato;
        private System.Windows.Forms.RadioButton rbMatricula;
        private System.Windows.Forms.RadioButton rbNome;
    }
}