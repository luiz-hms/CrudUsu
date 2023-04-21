using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using CrudUsu.Interfaces;
using CrudUsu.Model;

namespace CrudUsu
{
    public class Db
    {
        private static SQLiteConnection conexao;

        public static SQLiteConnection ConexaoDb()
        {
            conexao = new SQLiteConnection("Data Source="+Globais.caminhoDb + Globais.nomeDb);
            conexao.Open();
            return conexao;
        }

       
    }
}
