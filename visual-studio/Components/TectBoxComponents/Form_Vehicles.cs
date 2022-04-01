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
    public partial class Form_Vehicles : Form
    {

        Form_main formMain; 
        public Form_Vehicles(string vehicles, Form_main fMain)   // puxando um parâmetro da classe for_main
        {
            InitializeComponent();
            textBox_vehiclielist.Text = vehicles;

            formMain = fMain;    // campo local forMain recebe o parâmetro
            fMain.number = 10;
        }

        private void Form_Vehicles_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.textBox_listVehicles.Text = textBox_vehiclielist.Text;   // após mudar textBox_listVehicles para public obtermos acesso aqui e podemos acessar e modificar através desta classe filho
        }
    }
}
