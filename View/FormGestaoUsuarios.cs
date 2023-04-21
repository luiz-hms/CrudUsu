using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsu.Interfaces
{
    public partial class FormGestaoUsuarios : Form
    {
        public FormGestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = MetodosClientes.CarregaGdvUsuario();
            dgvUsuarios.Columns[0].Width = 85;
            dgvUsuarios.Columns[0].Width = 190;
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dataTable = MetodosClientes.BuscarDadosUsuario(vid);
                txtId.Text = dataTable.Rows[0].Field<Int64>("ID_USUARIO").ToString();
                txtNomeUsuarioCadastro.Text = dataTable.Rows[0].Field<string>("NOME_USUARIO").ToString();
                txtLoginUsuarioCadastro.Text = dataTable.Rows[0].Field<string>("LOGIN_USUARIO").ToString();
                txtSenhaUsuarioCadastro.Text = dataTable.Rows[0].Field<string>("SENHA_USUARIO").ToString();
                cmbUsuarioStatusCadastro.Text = dataTable.Rows[0].Field<string>("STATUS_USUARIO").ToString();
                nmudNivelUsuarioCadastro.Value = dataTable.Rows[0].Field<Int64>("NIVEL_USUARIO");
            }
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            FormNovoUsuario formNovoUsuario = new FormNovoUsuario();
            formNovoUsuario.ShowDialog();
            dgvUsuarios.DataSource = MetodosClientes.CarregaGdvUsuario();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario(Convert.ToInt32(txtId.Text), txtNomeUsuarioCadastro.Text, txtLoginUsuarioCadastro.Text, 
                txtSenhaUsuarioCadastro.Text, cmbUsuarioStatusCadastro.Text, Convert.ToInt32(nmudNivelUsuarioCadastro.Value));
            MetodosClientes.AtualizarDadosUsuario(u);
            dgvUsuarios.DataSource = MetodosClientes.CarregaGdvUsuario();
            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNomeUsuarioCadastro.Text;
            DialogResult res = MessageBox.Show($"Deseja relamente excluir esse usuario {nomeUsuario}?", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                MetodosClientes.ExcluirUsuario(txtId.Text);
                //após excluir apenas remove a linha excluida ao invés de recarregar todo o grid
                dgvUsuarios.Rows.Remove(dgvUsuarios.CurrentRow);
            }
        }
    }
}
