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
        public int number;
        public Form_main()
        {
            InitializeComponent();
            number = 0;
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

        private void btn_show_vehicles_Click(object sender, EventArgs e)
        {   // this irá passar o próprio elemento  como argumento
            Form_Vehicles form_Vehicles = new Form_Vehicles(textBox_listVehicles.Text, this);   // instanciar novo objeto
            form_Vehicles.ShowDialog();   // exibi a janela com o form anterior sem acesso
        }

        private void Btn_showvalue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(number.ToString(), "resultado");
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkBox form_CheckBox = new Form_checkBox();
            form_CheckBox.ShowDialog();
        }

        private void checkedListboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_checkedListBox checkedListBox = new Form_checkedListBox();
            checkedListBox.ShowDialog();
        }

        private void comboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox form_ComboBox = new comboBox();
            form_ComboBox.ShowDialog();
        }

        private void datetimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_dateTimePicker form_DateTimePicker = new Form_dateTimePicker();
            form_DateTimePicker.ShowDialog();
        }

        private void linkLabel_gitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/alamovinicius");  // sintaxe acesso ao navegador
        }

        private void linkLabel_calc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");    //npme do arquivo ou programa dentro do windows
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListBox newform = new FormListBox();
            newform.ShowDialog();
        }
    }
}   
