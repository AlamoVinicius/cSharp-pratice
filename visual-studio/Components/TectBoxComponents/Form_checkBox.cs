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
    public partial class Form_checkBox : Form
    {   

        List<CheckBox> transport = new List<CheckBox>();
        public Form_checkBox()
        {
            InitializeComponent();
            transport.Add(checkBox_carro);
            transport.Add(checkBox_aviao);
            transport.Add(checkBox_moto);
            transport.Add(checkBox_onibus);
            
        }

        private void Btn_checkedtransps_Click(object sender, EventArgs e)
        {
            string text = "";

            foreach (var item in transport)
            {
                if (item.Checked)
                {
                    text += $"{item.Text}, ";
                }
            }

            MessageBox.Show(text, "transportes marcados");
        }

        private void checkBox_skate_CheckedChanged(object sender, EventArgs e)   // event checked change
        {
            if (checkBox_skate.Checked)
            {
                string element = checkBox_skate.Text;
                MessageBox.Show($"Evento de marcação skate ativado, elemento: {element}");  //teste de interpolação 
            }
        }
    }
}
