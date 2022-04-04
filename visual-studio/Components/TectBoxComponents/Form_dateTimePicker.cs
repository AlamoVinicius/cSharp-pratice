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
    public partial class Form_dateTimePicker : Form
    {
        public Form_dateTimePicker()
        {
            InitializeComponent();
        }

        private void Btn_getData_Click(object sender, EventArgs e)
        {
            TextBox_data.Text = DateTimePicker_data.Text;
            TextBox_day.Text = DateTimePicker_data.Value.Day.ToString();
            textBox_mounth.Text = DateTimePicker_data.Value.Month.ToString();
            TextBox_year.Text = DateTimePicker_data.Value.Year.ToString();
        }

        private void Btn_SetData_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime(Int32.Parse(TextBox_year.Text),
                Int32.Parse(textBox_mounth.Text),
                Int32.Parse(TextBox_day.Text));
            DateTimePicker_data.Value = dateTime;   //get e set podemos configurar
        }
    }
}
