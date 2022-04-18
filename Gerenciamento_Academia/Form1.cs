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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            Form_login form_Login = new Form_login(this);   // passa esses elemntos para o construtor do form de login
            form_Login.ShowDialog();
        }

        private void lOGONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login form_Login = new Form_login(this);   
            form_Login.ShowDialog();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label_acess.Text = "0";
            label_name.Text = "---";
            pictureBox_ledlogado.Image = Properties.Resources.redLed;
            Globals.nivel = 0;
            Globals.logged = false;
        }

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logged)
            {
                if (Globals.nivel >= 2)
                {
                    // códigos
                } 
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("È necessário está logado no sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logged)
            {
                if (Globals.nivel >= 1)
                {
                    Form_newUser form_NewUser = new Form_newUser();
                    form_NewUser.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("È necessário está logado no sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logged)
            {
                if (Globals.nivel >= 1)
                {
                    // códigos
                }
                else
                {
                    MessageBox.Show("Nível de acesso não permitido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("È necessário está logado no sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.logged)
            {
               // código 
            }
            else
            {
                MessageBox.Show("È necessário está logado no sistema", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
