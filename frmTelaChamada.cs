using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolarSistemasLua
{
    public partial class frmTelaChamada : Form
    {
        public frmTelaChamada()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            frmTelaChamada frmtc = new frmTelaChamada();
            this.Close();

            frmGerarCodigo frmgc = new frmGerarCodigo();
            frmgc.Show();
        }

        private void btnQRcode_Click(object sender, EventArgs e)
        {
            frmTelaChamada frmtc = new frmTelaChamada();
            this.Close();

            frmChamadaQRcode frmCQRC = new frmChamadaQRcode();
            frmCQRC.Show();
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmTelaChamada frmtc = new frmTelaChamada();
            this.Close();

            frmChamadaManual fcm = new frmChamadaManual();
            fcm.Show();
        }
    }
}
