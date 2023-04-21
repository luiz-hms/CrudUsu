using CrudUsu.Interfaces;
using CrudUsu.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NovoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoCliente formNovoCliente = new FormNovoCliente();
            formNovoCliente.ShowDialog();
        }

        private void NovoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    FormNovoUsuario novoUsuario = new FormNovoUsuario();
                    novoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ACESSO NEGADO! Você não possui permissão para acessar essa parte do sistema.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");

            }

        }

        private void GestaoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    FormGestaoUsuarios formGestaoUsuarios = new FormGestaoUsuarios();
                    formGestaoUsuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ACESSO NEGADO! Você não possui permissão para acessar essa parte do sistema.");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado");

            }

        }

        private void GestaoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormGestaoClientes formGestaoClientes = new FormGestaoClientes();
            formGestaoClientes.ShowDialog();

        }

        private void LogonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }

        private void LogOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAcesso.Text = "0";
            lblNomeUsuario.Text = "---";
            Globais.nivel = 0;
            Globais.logado = false;
        }
    }
}
