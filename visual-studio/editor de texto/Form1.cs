using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.IO;


namespace editor_de_texto
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                int width = (int)SystemParameters.FullPrimaryScreenWidth;
                richTextBox1.Size = new Size(width - 400 , 600);
                richTextBox1.Location = new System.Drawing.Point(width / 7, 52);
            }
            else
            {
                richTextBox1.Size = new Size(800, 600);
                richTextBox1.Location = new Point(0, 52);
            }
        }

        private void New_file()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void Btn_new_Click(object sender, EventArgs e)
        {
            New_file();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_file();
        }
    }
}
