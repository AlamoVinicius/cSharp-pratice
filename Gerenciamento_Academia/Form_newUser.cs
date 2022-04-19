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
    public partial class Form_newUser : Form
    {
        public Form_newUser()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Collaborator collaborator = new Collaborator(TextBox_name.Text, TextBox_userName.Text, TextBox_password.Text, comboBox_status.Text, Convert.ToInt32(NumericUpDown_nivel.Value));
            DataBase.NewCollaborator(collaborator);
        }

        private void Button_cadastrar_Click(object sender, EventArgs e)
        {
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            TextBox_name.Clear();
            TextBox_password.Clear();
            TextBox_userName.Clear();
            comboBox_status.Text = "";
            NumericUpDown_nivel.Value = 0;
            TextBox_name.Focus();
        }
    }
}
