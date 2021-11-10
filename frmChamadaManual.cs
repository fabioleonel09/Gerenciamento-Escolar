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
    public partial class frmChamadaManual : Form
    {
        public frmChamadaManual()
        {
            InitializeComponent();
        }

        private void frmChamadaManual_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'GestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal'. Você pode movê-la ou removê-la conforme necessário.
            this.GestaoEscolarPrincipalTableAdapter.Fill(this.GestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal);

            this.reportViewer1.RefreshReport();
        }
    }
}
