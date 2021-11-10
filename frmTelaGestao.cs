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
    public partial class frmTelaGestao : Form
    {
        public frmTelaGestao()
        {
            InitializeComponent();

            //desabilita os groupBoxes
            gbFichaInicial.Enabled = false;
            gbCurso01.Enabled = false;
            gbCurso02.Enabled = false;
            gbCurso03.Enabled = false;
            gbCurso04.Enabled = false;
            gbCurso05.Enabled = false;
            gbOutroCurso.Enabled = false;
            gbTrabalho1.Enabled = false;
            gbTrabalho2.Enabled = false;
            gbTrabalho3.Enabled = false;
            gbTrabalho4.Enabled = false;
            gbTrabalho5.Enabled = false;
            gbTrabalhoOutro.Enabled = false;
            gbObservacoes.Enabled = false;

            //desabilita os checkBoxes
            cursoFinalizado1CheckBox.Checked = false;
            cursoFinalizado2CheckBox.Checked = false;
            cursoFinalizado3CheckBox.Checked = false;
            cursoFinalizado4CheckBox.Checked = false;
            cursoFinalizado5CheckBox.Checked = false;
            cursoFinalizadoOutroCheckBox.Checked = false;

            aprovado1CheckBox.Checked = false;
            aprovado2CheckBox.Checked = false;
            aprovado3CheckBox.Checked = false;
            aprovado4CheckBox.Checked = false;
            aprovado5CheckBox.Checked = false;
            aprovadoOutroCheckBox.Checked = false;

            reprovado1CheckBox.Checked = false;
            reprovado2CheckBox.Checked = false;
            reprovado3CheckBox.Checked = false;
            reprovado4CheckBox.Checked = false;
            reprovado5CheckBox.Checked = false;
            reprovadoOutroCheckBox.Checked = false;

            //desabilita o botão salvar
            gestaoEscolarPrincipalBindingNavigatorSaveItem.Enabled = false;

            //label para data
            lblData.Text = "Seja bem-vindo!   " + DateTime.Today.Date.ToShortDateString();           
        }

        //fecha a aplicação
        private void frmTelaGestao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //sobre os botões de ação
        private void btnChamada_Click(object sender, EventArgs e)
        {
            frmTelaChamada ftcham = new frmTelaChamada();
            ftcham.Show();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            frmContrato fcont = new frmContrato();
            fcont.Show();
        }

        //edita o botão "salvar" da barra de ferramentas do BD
        private void gestaoEscolarPrincipalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nomeAlunoTextBox.Text == "")
            {
                MessageBox.Show("Preencha o nome do aluno antes de salvar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                this.Validate();
                this.gestaoEscolarPrincipalBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gestaoEscolarSistemasLuaDataSet);

                MessageBox.Show("O cadastro foi salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbFichaInicial.Enabled = false;
                gbCurso01.Enabled = false;
                gbCurso02.Enabled = false;
                gbCurso03.Enabled = false;
                gbCurso04.Enabled = false;
                gbCurso05.Enabled = false;
                gbOutroCurso.Enabled = false;
                gbTrabalho1.Enabled = false;
                gbTrabalho2.Enabled = false;
                gbTrabalho3.Enabled = false;
                gbTrabalho4.Enabled = false;
                gbTrabalho5.Enabled = false;
                gbTrabalhoOutro.Enabled = false;
                gbObservacoes.Enabled = false;

                //desabilita o botão salvar
                gestaoEscolarPrincipalBindingNavigatorSaveItem.Enabled = false;
            }            
        }

        private void frmTelaGestao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal'. Você pode movê-la ou removê-la conforme necessário.
            this.gestaoEscolarPrincipalTableAdapter.Fill(this.gestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal);

        }

        //programa as ações dos comboBox`s
        private void cursoRealizado1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curso1;

            curso1 = cursoRealizado1ComboBox.Text;

            txtCurso01.Text = curso1.ToString();
        }

        private void cursoRealizado2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curso2;

            curso2 = cursoRealizado2ComboBox.Text;

            txtCurso02.Text = curso2.ToString();
        }

        private void cursoRealizado3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curso3;

            curso3 = cursoRealizado3ComboBox.Text;

            txtCurso03.Text = curso3.ToString();
        }

        private void cursoRealizado4ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curso4;

            curso4 = cursoRealizado4ComboBox.Text;

            txtCurso04.Text = curso4.ToString();
        }

        private void cursoRealizado5ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curso5;

            curso5 = cursoRealizado5ComboBox.Text;

            txtCurso05.Text = curso5.ToString();
        }

        private void outroTextBox_TextChanged(object sender, EventArgs e)
        {
            string cursoOutro;

            cursoOutro = outroTextBox.Text;

            txtCursoOutro.Text = cursoOutro.ToString();
        }

        //edita os botões da barra de ferramentas do BD
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //habilita os groupBoxes
            gbFichaInicial.Enabled = true;
            gbCurso01.Enabled = true;
            gbCurso02.Enabled = true;
            gbCurso03.Enabled = true;
            gbCurso04.Enabled = true;
            gbCurso05.Enabled = true;
            gbOutroCurso.Enabled = true;
            gbTrabalho1.Enabled = true;
            gbTrabalho2.Enabled = true;
            gbTrabalho3.Enabled = true;
            gbTrabalho4.Enabled = true;
            gbTrabalho5.Enabled = true;
            gbTrabalhoOutro.Enabled = true;
            gbObservacoes.Enabled = true;

            //habilita o botão salvar
            gestaoEscolarPrincipalBindingNavigatorSaveItem.Enabled = true;

            //desabilita os checkBoxes
            cursoFinalizado1CheckBox.Checked = false;
            cursoFinalizado2CheckBox.Checked = false;
            cursoFinalizado3CheckBox.Checked = false;
            cursoFinalizado4CheckBox.Checked = false;
            cursoFinalizado5CheckBox.Checked = false;
            cursoFinalizadoOutroCheckBox.Checked = false;

            aprovado1CheckBox.Checked = false;
            aprovado2CheckBox.Checked = false;
            aprovado3CheckBox.Checked = false;
            aprovado4CheckBox.Checked = false;
            aprovado5CheckBox.Checked = false;
            aprovadoOutroCheckBox.Checked = false;

            reprovado1CheckBox.Checked = false;
            reprovado2CheckBox.Checked = false;
            reprovado3CheckBox.Checked = false;
            reprovado4CheckBox.Checked = false;
            reprovado5CheckBox.Checked = false;
            reprovadoOutroCheckBox.Checked = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gestaoEscolarPrincipalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gestaoEscolarSistemasLuaDataSet);

            MessageBox.Show("O cadastro foi excluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //desabilita os groupBoxes
            gbFichaInicial.Enabled = false;
            gbCurso01.Enabled = false;
            gbCurso02.Enabled = false;
            gbCurso03.Enabled = false;
            gbCurso04.Enabled = false;
            gbCurso05.Enabled = false;
            gbOutroCurso.Enabled = false;
            gbTrabalho1.Enabled = false;
            gbTrabalho2.Enabled = false;
            gbTrabalho3.Enabled = false;
            gbTrabalho4.Enabled = false;
            gbTrabalho5.Enabled = false;
            gbTrabalhoOutro.Enabled = false;
            gbObservacoes.Enabled = false;

            //desabilita o botão salvar
            gestaoEscolarPrincipalBindingNavigatorSaveItem.Enabled = false;
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (nomeAlunoTextBox.Text == "")
            {
                MessageBox.Show("O procedimento é referente à edição de dados. Por favor, selecione uma ficha já preenchida para editar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                //habilita os groupBoxes
                gbFichaInicial.Enabled = true;
                gbCurso01.Enabled = true;
                gbCurso02.Enabled = true;
                gbCurso03.Enabled = true;
                gbCurso04.Enabled = true;
                gbCurso05.Enabled = true;
                gbOutroCurso.Enabled = true;
                gbTrabalho1.Enabled = true;
                gbTrabalho2.Enabled = true;
                gbTrabalho3.Enabled = true;
                gbTrabalho4.Enabled = true;
                gbTrabalho5.Enabled = true;
                gbTrabalhoOutro.Enabled = true;
                gbObservacoes.Enabled = true;

                //habilita o botão salvar
                gestaoEscolarPrincipalBindingNavigatorSaveItem.Enabled = true;
            }           
        }

        //implementa a pesquisa na caixa de texto
        private void txtPesquisarAluno_TextChanged(object sender, EventArgs e)
        {
            this.gestaoEscolarPrincipalTableAdapter.FillBy(this.gestaoEscolarSistemasLuaDataSet.GestaoEscolarPrincipal, txtPesquisarAluno.Text);
        }
    }
}
