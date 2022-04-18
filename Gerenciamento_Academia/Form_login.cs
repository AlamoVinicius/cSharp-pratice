using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_Academia
{
    public partial class Form_login : Form
    {
        Form_main form_Main;
        DataTable dt = new DataTable();
        public Form_login(Form_main f)
        {
            InitializeComponent();
            form_Main = f;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;  // get info dos inputs 
            string password = textBox_password.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("usuário ou senha inválidos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_username.Focus();
                return;
            }

            string sql = $"SELECT * FROM TB_USERS WHERE user_name = '{username}' AND password_user = '{password}'";  //sintaxe sql
            dt = DataBase.Consult(sql);
            if (dt.Rows.Count == 1)   // se o numero de linhas encontrado for igual a 1 logo ja existe um cadastro 
            {
                form_Main.label_acess.Text = dt.Rows[0].ItemArray[5].ToString();  // irá retornar o nivel de usuário de acordo com nossa estrutura do banco de dados
                form_Main.label_name.Text = dt.Rows[0].Field<string>("name"); //segundo modo de obter um dado do database no sqlite
                form_Main.pictureBox_ledlogado.Image = Properties.Resources.greenLed;  // altera o led do programa
                Globals.nivel = int.Parse(dt.Rows[0].Field<Int64>("int_nivelUser").ToString()); // ALTERAR variavel global 
                Globals.logged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();   //apenas fecha a janela
        }
    }
}
