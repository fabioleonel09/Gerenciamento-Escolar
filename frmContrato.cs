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
    public partial class frmContrato : Form
    {
        public frmContrato()
        {
            InitializeComponent();
            reportViewer1.Visible = false;
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'GestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal'. Você pode movê-la ou removê-la conforme necessário.
            this.GestaoEscolarPrincipalTableAdapter.Fill(this.GestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal);

            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrarContrato_Click(object sender, EventArgs e)
        {
            if (txtFiltrarContrato.Text == "")
            {
                MessageBox.Show("Digite o nome do aluno para imprimir o contrato!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);             
            }

            else
            {
                if ((rbNome.Checked == false) && (rbMatricula.Checked == false))
                {
                    MessageBox.Show("Marque 'Nome' ou 'Matrícula' para imprimir o contrato!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    if (rbNome.Checked == true)
                    {
                        this.GestaoEscolarPrincipalTableAdapter.FillBy(this.GestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal, txtFiltrarContrato.Text);
                        this.reportViewer1.RefreshReport();
                        txtFiltrarContrato.Clear();
                        rbNome.Checked = false;
                        rbMatricula.Checked = false;
                        reportViewer1.Visible = true;
                    }

                    else
                    {
                        if (rbMatricula.Checked == true)
                        {
                            this.GestaoEscolarPrincipalTableAdapter.FillByContrato(this.GestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal, Convert.ToInt32(txtFiltrarContrato.Text));
                            this.reportViewer1.RefreshReport();
                            txtFiltrarContrato.Clear();
                            rbNome.Checked = false;
                            rbMatricula.Checked = false;
                            reportViewer1.Visible = true;
                        }
                    }

                }
            }           
        }
    }
}
