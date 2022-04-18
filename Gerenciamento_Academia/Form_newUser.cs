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
        }

        private void Button_name_Click(object sender, EventArgs e)
        {

        }
    }
}
