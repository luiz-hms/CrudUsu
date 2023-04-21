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
    public partial class FormNovoUsuario : Form
    {
        private UsuarioController usuarioController;
        public FormNovoUsuario()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtNomeUsuarioCadastro.Text, txtLoginUsuarioCadastro.Text, txtSenhaUsuarioCadastro.Text, cmbUsuarioStatusCadastro.Text, Convert.ToInt32(Math.Round(nmudNivelUsuarioCadastro.Value, 0)));
            usuarioController.InserirNovoUsuario(usuario);
        }

        private void btnFecharCadastroUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarCadastroUsuario_Click(object sender, EventArgs e)
        {
            txtNomeUsuarioCadastro.Clear();
            txtLoginUsuarioCadastro.Clear();
            txtSenhaUsuarioCadastro.Clear();
            cmbUsuarioStatusCadastro.Text = string.Empty;
            nmudNivelUsuarioCadastro.Value = 0;
            txtNomeUsuarioCadastro.Focus();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            txtNomeUsuarioCadastro.Clear();
            txtLoginUsuarioCadastro.Clear();
            txtSenhaUsuarioCadastro.Clear();
            cmbUsuarioStatusCadastro.Text = string.Empty;
            nmudNivelUsuarioCadastro.Value = 0;
            txtNomeUsuarioCadastro.Focus();
        }
    }
}
