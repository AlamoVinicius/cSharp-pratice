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
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox_vehicle.Text == "")
            {
                MessageBox.Show("Digite um veículo");
                textBox_vehicle.Focus();
                return;
            }
            else
            {
                textBox_listVehicles.Text += textBox_vehicle.Text + " - ";
                textBox_vehicle.Clear();
                textBox_vehicle.Focus();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_listVehicles.Clear();
            textBox_vehicle.Clear();
            textBox_vehicle.Focus();
        }

        
    }
}
