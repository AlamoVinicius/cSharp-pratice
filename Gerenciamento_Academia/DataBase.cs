using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;   // import Data
using System.Data.SQLite;   // import sqlite  (instação através de pacote no projeto)
// todos os comentário farão referência ao estudo deste projeto 
namespace Gerenciamento_Academia
{
    class DataBase
    {
        private static SQLiteConnection connection;    // criação do membro para conectar ao sqlite

        private static SQLiteConnection DataConnection()   // função que irá facilitar o uso da conecção
        {
            connection = new SQLiteConnection("Data Source=C:\\Users\\VINICIUS\\Documents\\meus projetos github\\cSharp-pratice\\Gerenciamento_Academia\\db\\db_academy.db");  // necessário colocar DATAsource = string e \\ no caminho
            connection.Open();
            return connection;
        }

        public static DataTable GettAllUsers()    //dataTable from system data
        {
            SQLiteDataAdapter data = null;
            DataTable dtable = new DataTable();
            try
            {
                using (var cmd = DataConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_USERS";
                    data = new SQLiteDataAdapter(cmd.CommandText, DataConnection());  // usamos sqlitedataadapter para emitir os comando para o sqlite, de acordo com nossa programação 
                    data.Fill(dtable);   
                    connection.Close();   // desliga a conexção com database
                    return dtable;
                }
            }
            catch (Exception erro)
            {
                connection.Close();   
                throw erro;
            }
        }

        public static DataTable Consult(string sql)   // ao passar o comando por parâmetro eu habilito as possibilidades de verificações no formulário da classe pai
        {
            SQLiteDataAdapter datast = null;
            DataTable dtable = new DataTable();
            try
            {
                using (var cmd = DataConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    datast = new SQLiteDataAdapter(cmd.CommandText, DataConnection());  // usamos sqlitedataadapter para emitir os comando para o sqlite, de acordo com nossa programação 
                    datast.Fill(dtable);
                    connection.Close();
                    return dtable;
                }
            }
            catch (Exception erro)
            {
                connection.Close();
                throw erro;
            }
        }
        // funões do formulario de cadastro 

        public static void NewCollaborator(Collaborator colab)
        {
            if (AlreadyExistUsername(colab))
            {
                MessageBox.Show("Username já existe!");
                return;
            }
            try
            {
                var cmd = DataConnection().CreateCommand();
                cmd.CommandText = "INSERT INTO TB_USERS (name, user_name, password_user, status_user, int_nivelUser) VALUES (@nome, @username, @senha, @status, @nivel)";  //sintaxe parâmetros sql
                cmd.Parameters.AddWithValue("@nome", colab.NAME_USER);
                cmd.Parameters.AddWithValue("@username", colab.USERNAME);
                cmd.Parameters.AddWithValue("@senha", colab.PASSWORD);
                cmd.Parameters.AddWithValue("@status", colab.STATUS);
                cmd.Parameters.AddWithValue("@nivel", colab.NIVEL);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novó colaborador adicionado com sucesso!");
                connection.Close();
            }
            catch (Exception err)
            {

                throw err;
            }
        }

        public static bool AlreadyExistUsername(Collaborator colab)
        {

            SQLiteDataAdapter data = null;    // bucar um username especifico 
            DataTable dtable = new DataTable();
            var cmd = DataConnection().CreateCommand();
            cmd.CommandText = $"SELECT user_name FROM TB_USERS WHERE user_name = '{colab.USERNAME}'";
            data = new SQLiteDataAdapter(cmd.CommandText, DataConnection());
            data.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
