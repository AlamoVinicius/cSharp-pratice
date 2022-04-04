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
    public partial class Form_checkedListBox : Form
    {
        public Form_checkedListBox()
        {
            InitializeComponent();
        }

        private void Btn_showSelected_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (var item in checkedListBox_transports.CheckedItems)
            {
                text += $"{item}";
                if (item == checkedListBox_transports.CheckedItems[checkedListBox_transports.CheckedItems.Count - 1])  // comparação com ultimo item da collection
                {
                    text += "";
                } 
                else
                {
                    text += " - ";
                }
            }
            
            MessageBox.Show(text, "resultados");
        }

        private void Btn_clearList_Click(object sender, EventArgs e)
        {
            checkedListBox_transports.Items.Clear();   // limpa lista de checked list box
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            checkedListBox_transports.Items.Clear();
            checkedListBox_transports.Items.AddRange(new object[] {   
            "CARRO",
            "AVIÃO",
            "NAVIO",
            "ONIBUS",
            "TREM"});  // método para resetar a lista
        }

        private void Btn_addNewTransport_Click(object sender, EventArgs e)
        {
            string newItem = textBox_addNewTransport.Text.ToUpper();
            if ( newItem == "")
            {
                MessageBox.Show("erro, digite um transporte", "erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else if (checkedListBox_transports.Items.Contains(newItem))
            {
                MessageBox.Show("erro, transporte já existe", "erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            checkedListBox_transports.Items.Add(newItem);
            textBox_addNewTransport.Clear();
            textBox_addNewTransport.Focus();
        }
    }
}
