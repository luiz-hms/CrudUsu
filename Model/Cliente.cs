using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsu.Model
{
    public class Cliente
    {
        public int id_cliente;
        public string nome_cliente;
        public string telefone_cliente;
        public string cpf_cliente;
        public string status_cliente;

        public Cliente()
        {

        }

        public Cliente(int _id, string _nome, string _telefone, string _cpf, string _status)
        {
            id_cliente = _id;
            nome_cliente = _nome;
            telefone_cliente = _telefone;
            cpf_cliente = _cpf;
            status_cliente = _status;
        }

        public Cliente(string _nome, string _telefone, string _cpf, string _status)
        {
            nome_cliente = _nome;
            telefone_cliente = _telefone;
            cpf_cliente = _cpf;
            status_cliente = _status;
        }
    }
}
