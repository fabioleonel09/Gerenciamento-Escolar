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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //sobre o botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //sobre o botão entrar e a senha
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "administrativo")
            {
                this.Visible = false;
                frmTelaGestao ftg = new frmTelaGestao();
                ftg.Show();
            }

            else
            {
                MessageBox.Show("A senha está incorreta. Por favor, tente novamente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Clear();
            }
        }
    }
}
