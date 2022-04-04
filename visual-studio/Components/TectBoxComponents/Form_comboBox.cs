using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TectBoxComponents
{
    public partial class comboBox : Form
    {
        public comboBox()
        {
            InitializeComponent();
        }

        private void Btn_showSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ComboBox_transports.Text);
        }

        private void Btn_clearElements_Click(object sender, EventArgs e)
        {
            ComboBox_transports.Items.Clear();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            ComboBox_transports.Items.Clear();
            ComboBox_transports.Items.AddRange(new string[] {"CARRO",
            "AVIÃO",
            "NAVIO",
            "ONIBUS",
            "TREM" });
        }

        private void Btn_addnewTransport_Click(object sender, EventArgs e)
        {
            ComboBox_transports.Items.Add(TextBox_addnewTransport.Text.ToUpper());
            TextBox_addnewTransport.Clear();
            TextBox_addnewTransport.Focus();
        }

        private void ComboBox_transports_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox_addnewTransport.Text = ComboBox_transports.Text;
        }
    }
}
