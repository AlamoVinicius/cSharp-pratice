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
    public partial class FormListBox : Form
    {   
        public List<string> vehicles = new List<string>();
        public FormListBox()
        {
            
            
            InitializeComponent();
            vehicles.AddRange(new string[] { "Ferrari", "Golf", "Fiesta", "Argo" });
            listBox_vehicles.DataSource = vehicles;   // sintaxe dados podem vim de um database por exemplo
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            vehicles.Add(textBox1.Text);
            textBox1.Clear();
            Update_vehicleList(listBox_vehicles, vehicles);       // dados podem vim de um data base 
        }

        private void Bnt_remove_Click(object sender, EventArgs e)
        {
            vehicles.RemoveAt(listBox_vehicles.SelectedIndex);
            Update_vehicleList(listBox_vehicles, vehicles);  
        }

        private void Btn_get_Click(object sender, EventArgs e)
        {
            textBox1.Text = vehicles[listBox_vehicles.SelectedIndex];
        }

        private void Update_vehicleList(ListBox list, List<string> strList)
        {
            list.DataSource = null;     // método para exluir determinado item 
            list.DataSource = strList;
        }
    }
}
