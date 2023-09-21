using ReaLTaiizor.Forms;

namespace Projeto4
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.MdiParent = this;
            formCadastro.Show();
        }

        private void FormPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeCursosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioAluno formRelatorioAluno = new FormRelatorioAluno();
            formRelatorioAluno.MdiParent = this;
            formRelatorioAluno.Show();
        }

        private void cadastroDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfessor formProfessor = new FormProfessor();
            formProfessor.MdiParent = this;
            formProfessor.Show();
        }

        private void relatórioDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioProfessor formRelatorioProfessor = new FormRelatorioProfessor();
            formRelatorioProfessor.MdiParent = this;
            formRelatorioProfessor.Show();
        }

        private void relatóiroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioCurso formRelatorioCurso = new FormRelatorioCurso();
            formRelatorioCurso.MdiParent = this;
            formRelatorioCurso.Show();
        }
    }
}
