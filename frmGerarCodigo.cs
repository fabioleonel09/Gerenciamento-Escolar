using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using QRCoder;

namespace GestaoEscolarSistemasLua
{
    public partial class frmGerarCodigo : Form
    {
        public frmGerarCodigo()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBarras.TextLength == 12)
            {
                pbCodigoBarras.Image = null;
                Barcode barcode = new Barcode();
                Color foreColor = Color.Black;
                Color backColor = Color.Transparent;
                Image img = barcode.Encode(TYPE.UPCA, txtCodigoBarras.Text, foreColor, backColor, (int)(pbCodigoBarras.Width * 0.8), (int)(pbCodigoBarras.Height * 0.8));
                pbCodigoBarras.Image = img;
            }

            else
            {
                MessageBox.Show("São necessários 12 números para gerar o código de barras!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            pbCodigoBarras.Image = null;
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtCodigoBarras.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pbCodigoBarras.Image = code.GetGraphic(5);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pbCodigoBarras.Image == null)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    pbCodigoBarras.Image.Save(saveFileDialog.FileName);
            }
        }
    }
}
