using CrudUsu.Model;
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
    class MetodosCliente : Db
    {
        public static DataTable CarregaGdvClientes() 
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT ID_CLIENTE as 'ID Usuário', NOME_CLIENTE as 'Nome Usuário' FROM CLIENTES";
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


        public static void AtualizarDadosCliente(Cliente cli) 
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE CLIENTES SET NOME_CLIENTE = '" + cli.nome_cliente + "'," +
                     "TELEFONE_CLIENTE = '" + cli.telefone_cliente + "', " +
                     "CPF_CLIENTE = '" + cli.cpf_cliente + "', " +
                     "STATUS_CLIENTE = '" + cli.status_cliente + "', " +
                     " WHERE ID_CLIENTE =" + cli.id_cliente;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ExcluirCliente(String id) 
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM CLIENTES WHERE ID_CLIENTE = " + id;
                dataAdapter = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable BuscarDadosCliente(string id)
        {
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = $"SELECT * FROM CLIENTES WHERE ID_CLIENTE = {id}";
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



        public static void InserirNovoCliente(Cliente cliente)
        {
            if (VerificaCpf(cliente))
            {
                MessageBox.Show("Um cliente com o cpf informado já está cadastrado.");
                return;
            }
            try
            {
                var vcon = ConexaoDb();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO CLIENTES (NOME_CLIENTE, TELEFONE_CLIENTE, CPF_CLIENTE, STATUS_CLIENTE) VALUES (@nome_cliente, @telefone_cliente, @cpf_cliente, @status_cliente)";
                cmd.Parameters.AddWithValue("@nome_cliente", cliente.nome_cliente);
                cmd.Parameters.AddWithValue("@telefone_cliente", cliente.telefone_cliente);
                cmd.Parameters.AddWithValue("@cpf_cliente", cliente.cpf_cliente);
                cmd.Parameters.AddWithValue("@status_cliente", cliente.status_cliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente inserido com sucesso");
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo cliente");
            }
        }

        public static bool VerificaCpf(Cliente cliente)
        {
            bool resposta;
            SQLiteDataAdapter dataAdapter = null;
            DataTable dataTable = new DataTable();
            var vcon = ConexaoDb();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = $@"SELECT CPF_CLIENTE FROM CLIENTES WHERE CPF_CLIENTE = '{cliente.cpf_cliente}'";
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
