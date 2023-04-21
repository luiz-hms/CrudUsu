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
    public partial class FormLogin : Form
    {
        Form1 form1;
        DataTable dataTable = new DataTable();
        public FormLogin(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            txtLogin.Focus();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string usuarioLogin = txtLogin.Text;
            string usuarioSenha = txtSenha.Text;
            if (usuarioLogin == "" || usuarioSenha == "")
            {

                MessageBox.Show("Usuario e ou senha invalidos");
                txtLogin.Focus();
                return;
            }
            string sql = "SELECT * FROM usuarios WHERE LOGIN_USUARIO = '" + usuarioLogin + "' AND SENHA_USUARIO = '" + usuarioSenha + "'";
            dataTable = MetodosClientes.Consulta(sql);
            if(dataTable.Rows.Count == 1)
            {
                form1.lblAcesso.Text = dataTable.Rows[0].ItemArray[5].ToString();
                form1.lblNomeUsuario.Text = dataTable.Rows[0].ItemArray[2].ToString();
                Globais.nivel = int.Parse(dataTable.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
