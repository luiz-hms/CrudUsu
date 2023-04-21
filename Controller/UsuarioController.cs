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
        /* public static DataTable BuscarDadosUsuario(string id)
         {

             try
             {
                 Db.InserirNovoUsuario(usuario);

             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }*/

        public void InserirNovoUsuario(Usuario usu)
        {
           
            try
            {
                Db.InserirNovoUsuario(usu);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuario");
            }
        }
    }
}
