using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudUsu
{
    public class MetodosClientes : Db
    {
        public static DataTable CarregaGdvUsuario()
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT ID_USUARIO as 'ID Usuário', NOME_USUARIO as 'Nome Usuário' FROM usuarios";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InserirNovoUsuario(Usuario usu)
        {
            if (VerificaLoginUsuario(usu))
            {
                MessageBox.Show("Esse login de usuário já está em uso");
                return;
            }
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO USUARIOS (NOME_USUARIO, LOGIN_USUARIO, SENHA_USUARIO, STATUS_USUARIO, NIVEL_USUARIO) VALUES (@nome_usuario, @login_usuario, @senha_usuario, @status_usuario, @nivel_usuario)";
                cmd.Parameters.AddWithValue("@nome_usuario", usu.nome_usuario);
                cmd.Parameters.AddWithValue("@login_usuario", usu.login_usuario);
                cmd.Parameters.AddWithValue("@senha_usuario", usu.senha_usuario);
                cmd.Parameters.AddWithValue("@status_usuario", usu.status_usuario);
                cmd.Parameters.AddWithValue("@nivel_usuario", usu.nivel_usuario);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuário inserido com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuario");
            }
        }

        public static void AtualizarDadosUsuario(Usuario u)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE usuarios SET NOME_USUARIO = '" + u.nome_usuario + "'," +
                     "LOGIN_USUARIO = '" + u.login_usuario + "', " +
                     "SENHA_USUARIO = '" + u.senha_usuario + "', " +
                     "STATUS_USUARIO = '" + u.status_usuario + "', " +
                     "NIVEL_USUARIO = " + u.nivel_usuario + " WHERE ID_USUARIO =" + u.id_usuario;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirUsuario(String id)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM usuarios WHERE ID_USUARIO = " + id;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable BuscarDadosUsuario(string id) 
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = $"SELECT * FROM usuarios WHERE ID_USUARIO = {id}";
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();
                return dataTable;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                dataAdapter.Fill(dataTable);
                vcon.Close();
                return dataTable;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static bool VerificaLoginUsuario(Usuario u)
        {
            bool resposta;
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            var vcon = ConexaoDb();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = $@"SELECT LOGIN_USUARIO FROM USUARIOS WHERE LOGIN_USUARIO = '{u.login_usuario}'";
            dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }
            vcon.Close();
            return resposta;
        }
    }
}
