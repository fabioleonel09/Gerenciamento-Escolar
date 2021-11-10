namespace GestaoEscolarSistemasLua
{
    partial class frmGerarCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarCodigo));
            this.btnQRcode = new System.Windows.Forms.Button();
            this.pbCodigoBarras = new System.Windows.Forms.PictureBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQRcode
            // 
            this.btnQRcode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQRcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQRcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRcode.Location = new System.Drawing.Point(12, 417);
            this.btnQRcode.Name = "btnQRcode";
            this.btnQRcode.Size = new System.Drawing.Size(200, 30);
            this.btnQRcode.TabIndex = 11;
            this.btnQRcode.Text = "&Gerar código QR code";
            this.btnQRcode.UseVisualStyleBackColor = false;
            this.btnQRcode.Click += new System.EventHandler(this.btnQRcode_Click);
            // 
            // pbCodigoBarras
            // 
            this.pbCodigoBarras.BackColor = System.Drawing.SystemColors.Window;
            this.pbCodigoBarras.Location = new System.Drawing.Point(12, 12);
            this.pbCodigoBarras.Name = "pbCodigoBarras";
            this.pbCodigoBarras.Size = new System.Drawing.Size(584, 192);
            this.pbCodigoBarras.TabIndex = 9;
            this.pbCodigoBarras.TabStop = false;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(218, 417);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(200, 30);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "&Gerar código de barras";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Salmon;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(424, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(172, 30);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digite o texto ou a sequência numérica para gerar o código";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(6, 25);
            this.txtCodigoBarras.Multiline = true;
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCodigoBarras.Size = new System.Drawing.Size(572, 152);
            this.txtCodigoBarras.TabIndex = 11;
            this.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGerarCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQRcode);
            this.Controls.Add(this.pbCodigoBarras);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnSalvar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmGerarCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar código";
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigoBarras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQRcode;
        private System.Windows.Forms.PictureBox pbCodigoBarras;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
    }
}