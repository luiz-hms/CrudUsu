using CrudUsu.Controller;
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
    public partial class FormNovoCliente : Form
    {
        private ClienteController clienteController;
        public FormNovoCliente()
        {
            InitializeComponent();
            clienteController = new ClienteController();
        }

        private void FormNovoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            
            txtNomeCliente.Clear();
            mtbTelefoneCliente.Clear();
            mtbCpfCliente.Clear();
            cmbStatusCliente.SelectedIndex = 0;
            txtNomeCliente.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            mtbTelefoneCliente.Clear();
            mtbCpfCliente.Clear();
            cmbStatusCliente.SelectedIndex = 0;
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNomeCliente.Text, mtbTelefoneCliente.Text, mtbCpfCliente.Text, cmbStatusCliente.Text);
            clienteController.InserirNovoCliente(cliente);
            txtNomeCliente.Clear();
            mtbTelefoneCliente.Clear();
            mtbCpfCliente.Clear();
            cmbStatusCliente.SelectedIndex = 0;
            txtNomeCliente.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
