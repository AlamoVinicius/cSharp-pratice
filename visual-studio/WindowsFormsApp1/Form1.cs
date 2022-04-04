using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Btn_text_Click(object sender, EventArgs e)
        {
            lb_text.Text = Text_box.Text;
            if (btn_text.Text == "Click on me")
            {
                btn_text.Text = "Hello boy, click on me again ;)";
            }
            else
            {
                btn_text.Text = "Click on me";
            }

        }
    }
}
