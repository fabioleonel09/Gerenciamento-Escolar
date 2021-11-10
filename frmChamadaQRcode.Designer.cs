namespace GestaoEscolarSistemasLua
{
    partial class frmChamadaQRcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamadaQRcode));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtQRCode = new System.Windows.Forms.TextBox();
            this.btnSairJanela = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBiblioteca = new System.Windows.Forms.Button();
            this.btnSairBiblioteca = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(302, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Abrir a chamada";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a câmera:";
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(176, 12);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(279, 26);
            this.cboDevice.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 44);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(284, 284);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // txtQRCode
            // 
            this.txtQRCode.Location = new System.Drawing.Point(302, 127);
            this.txtQRCode.Multiline = true;
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQRCode.Size = new System.Drawing.Size(329, 450);
            this.txtQRCode.TabIndex = 4;
            // 
            // btnSairJanela
            // 
            this.btnSairJanela.BackColor = System.Drawing.Color.Salmon;
            this.btnSairJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairJanela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairJanela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairJanela.Location = new System.Drawing.Point(461, 12);
            this.btnSairJanela.Name = "btnSairJanela";
            this.btnSairJanela.Size = new System.Drawing.Size(170, 26);
            this.btnSairJanela.TabIndex = 5;
            this.btnSairJanela.Text = "Sair da tela";
            this.btnSairJanela.UseVisualStyleBackColor = false;
            this.btnSairJanela.Click += new System.EventHandler(this.btnSairJanela_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(461, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fechar a chamada";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBiblioteca
            // 
            this.btnBiblioteca.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiblioteca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBiblioteca.Location = new System.Drawing.Point(302, 86);
            this.btnBiblioteca.Name = "btnBiblioteca";
            this.btnBiblioteca.Size = new System.Drawing.Size(153, 36);
            this.btnBiblioteca.TabIndex = 8;
            this.btnBiblioteca.Text = "Biblioteca";
            this.btnBiblioteca.UseVisualStyleBackColor = false;
            this.btnBiblioteca.Click += new System.EventHandler(this.btnBiblioteca_Click);
            // 
            // btnSairBiblioteca
            // 
            this.btnSairBiblioteca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSairBiblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairBiblioteca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairBiblioteca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairBiblioteca.Location = new System.Drawing.Point(461, 86);
            this.btnSairBiblioteca.Name = "btnSairBiblioteca";
            this.btnSairBiblioteca.Size = new System.Drawing.Size(170, 36);
            this.btnSairBiblioteca.TabIndex = 9;
            this.btnSairBiblioteca.Text = "Sair biblioteca";
            this.btnSairBiblioteca.UseVisualStyleBackColor = false;
            this.btnSairBiblioteca.Click += new System.EventHandler(this.btnSairBiblioteca_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(12, 334);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(284, 243);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir chamada / relatório";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmChamadaQRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 589);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSairBiblioteca);
            this.Controls.Add(this.btnBiblioteca);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSairJanela);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChamadaQRcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamada por QRcode";
            this.Load += new System.EventHandler(this.frmChamadaQRcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtQRCode;
        private System.Windows.Forms.Button btnSairJanela;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBiblioteca;
        private System.Windows.Forms.Button btnSairBiblioteca;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnImprimir;
    }
}