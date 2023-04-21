using CrudUsu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsu.View
{
    public partial class FormGestaoClientes : Form
    {
        public FormGestaoClientes()
        {
            InitializeComponent();
        }

        private void btnFecharJanela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGestaoClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = MetodosCliente.CarregaGdvClientes();
            dgvClientes.Columns[0].Width = 85;
            dgvClientes.Columns[0].Width = 190;
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dataTable = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dataTable = MetodosCliente.BuscarDadosCliente(vid);
                txtId.Text = dataTable.Rows[0].Field<Int64>("ID_CLIENTE").ToString();
                txtNomeCliente.Text = dataTable.Rows[0].Field<string>("NOME_CLIENTE").ToString();
                mtbTelefoneCliente.Text = dataTable.Rows[0].Field<string>("TELEFONE_CLIENTE").ToString();
                mtbCpfCliente.Text = dataTable.Rows[0].Field<string>("CPF_CLIENTE").ToString();
                cmbClienteStatus.Text = dataTable.Rows[0].Field<string>("STATUS_CLIENTE").ToString();
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente formNovoCliente = new FormNovoCliente();
            formNovoCliente.ShowDialog();
            dgvClientes.DataSource = MetodosCliente.CarregaGdvClientes();
        }

        private void btnSalvarAlteracoes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(Convert.ToInt32(txtId.Text), txtNomeCliente.Text, mtbTelefoneCliente.Text,
               mtbCpfCliente.Text, cmbClienteStatus.Text);
            MetodosCliente.AtualizarDadosCliente(cliente);
            dgvClientes.DataSource = MetodosCliente.CarregaGdvClientes();
            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text;
            DialogResult res = MessageBox.Show($"Deseja relamente excluir esse usuario {nomeCliente}?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MetodosCliente.ExcluirCliente(txtId.Text);
                //após excluir apenas remove a linha excluida ao invés de recarregar todo o grid
                dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
            }
        }
    }
}
