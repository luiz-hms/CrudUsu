using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsu
{
    public class Usuario
    {
        public int id_usuario;
        public string nome_usuario;
        public string login_usuario;
        public string senha_usuario;
        public string status_usuario;
        public int nivel_usuario;

        public Usuario()
        {

        }

        public Usuario(int _id, string _nome, string _login, string _senha, string _status, int _nivel)
        {
            id_usuario = _id;
            nome_usuario = _nome;
            login_usuario = _login;
            senha_usuario = _senha;
            status_usuario = _status;
            nivel_usuario = _nivel;
        }

        public Usuario(string _nome, string _login, string _senha, string _status, int _nivel)
        {
            nome_usuario = _nome;
            login_usuario = _login;
            senha_usuario = _senha;
            status_usuario = _status;
            nivel_usuario = _nivel;
        }
    }
}
