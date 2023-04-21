using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsu
{
    public class UsuarioController
    {
        public UsuarioController()
        {
           
        }
        
        public void InserirNovoUsuario(Usuario usu)
        {
           
            try
            {
                MetodosClientes.InserirNovoUsuario(usu);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuario");
            }
        }

        public void CarregaGdvUsuario()
        {
           
            try
            {
                MetodosClientes.CarregaGdvUsuario();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void VerificaLoginUsuario(Usuario usu)
        {

            try
            {
                MetodosClientes.VerificaLoginUsuario(usu);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarDadosUsuario(Usuario usu)
        {
            try
            {
                MetodosClientes.AtualizarDadosUsuario(usu);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExcluirUsuario(string id)
        {
            try
            {
                MetodosClientes.ExcluirUsuario(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BuscarDadosUsuario(string id)
        {
            try
            {
                MetodosClientes.ExcluirUsuario(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
