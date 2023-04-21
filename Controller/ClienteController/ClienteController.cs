using CrudUsu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsu.Controller
{
    class ClienteController
    {
        public ClienteController()
        {

        }

        public void InserirNovoCliente(Cliente cliente)
        {

            try
            {
                MetodosCliente.InserirNovoCliente(cliente);

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
                MetodosCliente.CarregaGdvClientes();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void VerificaCpf(Cliente cliente)
        {

            try
            {
                MetodosCliente.VerificaCpf(cliente);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AtualizarDadosUsuario(Cliente cliente)
        {
            try
            {
                MetodosCliente.AtualizarDadosCliente(cliente);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ExcluirCliente(string id)
        {
            try
            {
                MetodosCliente.ExcluirCliente(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BuscarDadosClientes(string id)
        {
            try
            {
                MetodosCliente.BuscarDadosCliente(id);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
