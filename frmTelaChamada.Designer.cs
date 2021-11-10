namespace GestaoEscolarSistemasLua
{
    partial class frmTelaChamada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaChamada));
            this.btnQRcode = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQRcode
            // 
            this.btnQRcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQRcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRcode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRcode.Image = ((System.Drawing.Image)(resources.GetObject("btnQRcode.Image")));
            this.btnQRcode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQRcode.Location = new System.Drawing.Point(68, 49);
            this.btnQRcode.Name = "btnQRcode";
            this.btnQRcode.Size = new System.Drawing.Size(300, 345);
            this.btnQRcode.TabIndex = 0;
            this.btnQRcode.Text = "com QRcode";
            this.btnQRcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQRcode.UseVisualStyleBackColor = true;
            this.btnQRcode.Click += new System.EventHandler(this.btnQRcode_Click);
            // 
            // btnManual
            // 
            this.btnManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Image = ((System.Drawing.Image)(resources.GetObject("btnManual.Image")));
            this.btnManual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManual.Location = new System.Drawing.Point(437, 49);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(300, 162);
            this.btnManual.TabIndex = 1;
            this.btnManual.Text = "de forma manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerar.Image")));
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGerar.Location = new System.Drawing.Point(437, 232);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(300, 162);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar QRcode ou barras";
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // frmTelaChamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnQRcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTelaChamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de chamada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQRcode;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnGerar;
    }
}