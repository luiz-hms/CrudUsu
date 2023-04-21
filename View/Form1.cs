using CrudUsu.Interfaces;
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

        private void lOGONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAcesso.Text = "0";
            //form1.lblNomeUsuario.Text = dataTable.Rows[0].ItemArray[2].ToString();
            lblNomeUsuario.Text = "---";
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void BANCODEDADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if(Globais.nivel >= 2)
                {

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nOVOUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void gESTÃODEUSUÁRIOSToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nOVOCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 0)
                {

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
    }
}
