
namespace TectBoxComponents
{
    partial class FormListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_vehicles = new System.Windows.Forms.ListBox();
            this.Btn_add = new System.Windows.Forms.Button();
            this.Bnt_remove = new System.Windows.Forms.Button();
            this.Btn_get = new System.Windows.Forms.Button();
            this.label_carro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox_vehicles
            // 
            this.listBox_vehicles.FormattingEnabled = true;
            this.listBox_vehicles.Location = new System.Drawing.Point(13, 13);
            this.listBox_vehicles.Name = "listBox_vehicles";
            this.listBox_vehicles.Size = new System.Drawing.Size(147, 212);
            this.listBox_vehicles.TabIndex = 0;
            // 
            // Btn_add
            // 
            this.Btn_add.Location = new System.Drawing.Point(166, 56);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(162, 23);
            this.Btn_add.TabIndex = 1;
            this.Btn_add.Text = "Adicionar";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Bnt_remove
            // 
            this.Bnt_remove.Location = new System.Drawing.Point(166, 108);
            this.Bnt_remove.Name = "Bnt_remove";
            this.Bnt_remove.Size = new System.Drawing.Size(162, 23);
            this.Bnt_remove.TabIndex = 2;
            this.Bnt_remove.Text = "Remover";
            this.Bnt_remove.UseVisualStyleBackColor = true;
            this.Bnt_remove.Click += new System.EventHandler(this.Bnt_remove_Click);
            // 
            // Btn_get
            // 
            this.Btn_get.Location = new System.Drawing.Point(166, 137);
            this.Btn_get.Name = "Btn_get";
            this.Btn_get.Size = new System.Drawing.Size(162, 23);
            this.Btn_get.TabIndex = 3;
            this.Btn_get.Text = "Obter";
            this.Btn_get.UseVisualStyleBackColor = true;
            this.Btn_get.Click += new System.EventHandler(this.Btn_get_Click);
            // 
            // label_carro
            // 
            this.label_carro.AutoSize = true;
            this.label_carro.Location = new System.Drawing.Point(167, 13);
            this.label_carro.Name = "label_carro";
            this.label_carro.Size = new System.Drawing.Size(35, 13);
            this.label_carro.TabIndex = 4;
            this.label_carro.Text = "Carro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 5;
            // 
            // FormListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_carro);
            this.Controls.Add(this.Btn_get);
            this.Controls.Add(this.Bnt_remove);
            this.Controls.Add(this.Btn_add);
            this.Controls.Add(this.listBox_vehicles);
            this.Name = "FormListBox";
            this.Text = "FormListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_vehicles;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Button Bnt_remove;
        private System.Windows.Forms.Button Btn_get;
        private System.Windows.Forms.Label label_carro;
        private System.Windows.Forms.TextBox textBox1;
    }
}