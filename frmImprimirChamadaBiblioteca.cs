using Microsoft.Reporting.WinForms;
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
    public partial class frmImprimirChamadaBiblioteca : Form
    {
        public frmImprimirChamadaBiblioteca(string QRCode)
        {
            InitializeComponent();

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "GestaoEscolarSistemasLua.rpImprimirChamadaBiblioteca.rdlc";

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[1];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("QRCode", QRCode);

            reportViewer1.LocalReport.SetParameters(p);

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void frmImprimirChamadaBiblioteca_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
