using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudUsu.Interfaces
{
    class Globais
    {
        public static int nivel = 0;
        public static bool logado = false;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeDb = "Db_CrudUsu";
        public static string caminhoDb = caminho + @"\DB\";
    }
}


/*
    ID_USUARIO
    NOME_USUARIO
    LOGIN_USUARIO
    SENHA_USUARIO
    STATUS_USUARIO
    NIVEL_USUARIO
 
 */
