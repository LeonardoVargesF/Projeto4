using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace Projeto4
{
    public partial class FormCadastro : MaterialForm
    {
        bool isAlteracao = false;
        string cs = @"server=127.0.0.1;" + "uid=root;" + "pwd=;" + "database=academico";
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                materialTabControl1.SelectedIndex = 1;
            }
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            if (!isAlteracao)
            {
                var sql = "INSERT INTO aluno(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha)" +
                    "VALUES(@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
                var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                DateTime.TryParse(txtDataNasc.Text, out var dataNascimento);
                cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            else
            {          
            }
            LimpaCampos();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula Obrigatoria", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome Obrigatorio", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Cidade Obrigatoria", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Endereço Obrigatorio", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha Obrigatoria", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Bairro Obrigatorio", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDataNasc.Text, out DateTime _))
            {
                MessageBox.Show("Data de Nascimento Obrigatoria", "IFSP",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNasc.Focus();
                return false;
            }

            return true;
        }

        private void LimpaCampos()
        {
            isAlteracao = false;
            foreach (var control in tabPage1.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(cs);
            con.Open();


            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
