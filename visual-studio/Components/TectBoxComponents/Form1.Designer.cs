
namespace TectBoxComponents
{
    partial class Form_main
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
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vehicle = new System.Windows.Forms.TextBox();
            this.textBox_listVehicles = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show_vehicles = new System.Windows.Forms.Button();
            this.Btn_showvalue = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(208, 82);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um Veículo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_vehicle
            // 
            this.textBox_vehicle.Location = new System.Drawing.Point(10, 82);
            this.textBox_vehicle.Name = "textBox_vehicle";
            this.textBox_vehicle.Size = new System.Drawing.Size(192, 20);
            this.textBox_vehicle.TabIndex = 2;
            // 
            // textBox_listVehicles
            // 
            this.textBox_listVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_listVehicles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_listVehicles.Location = new System.Drawing.Point(10, 108);
            this.textBox_listVehicles.Multiline = true;
            this.textBox_listVehicles.Name = "textBox_listVehicles";
            this.textBox_listVehicles.ReadOnly = true;
            this.textBox_listVehicles.Size = new System.Drawing.Size(273, 244);
            this.textBox_listVehicles.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(13, 364);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(268, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_show_vehicles
            // 
            this.btn_show_vehicles.Location = new System.Drawing.Point(13, 394);
            this.btn_show_vehicles.Name = "btn_show_vehicles";
            this.btn_show_vehicles.Size = new System.Drawing.Size(268, 23);
            this.btn_show_vehicles.TabIndex = 5;
            this.btn_show_vehicles.Text = "Mostrar veículos";
            this.btn_show_vehicles.UseVisualStyleBackColor = true;
            this.btn_show_vehicles.Click += new System.EventHandler(this.btn_show_vehicles_Click);
            // 
            // Btn_showvalue
            // 
            this.Btn_showvalue.Location = new System.Drawing.Point(13, 423);
            this.Btn_showvalue.Name = "Btn_showvalue";
            this.Btn_showvalue.Size = new System.Drawing.Size(268, 23);
            this.Btn_showvalue.TabIndex = 6;
            this.Btn_showvalue.Text = "valor váriavel number";
            this.Btn_showvalue.UseVisualStyleBackColor = true;
            this.Btn_showvalue.Click += new System.EventHandler(this.Btn_showvalue_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListboxToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListboxToolStripMenuItem
            // 
            this.checkedListboxToolStripMenuItem.Name = "checkedListboxToolStripMenuItem";
            this.checkedListboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListboxToolStripMenuItem.Text = "CheckedListbox";
            this.checkedListboxToolStripMenuItem.Click += new System.EventHandler(this.checkedListboxToolStripMenuItem_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 484);
            this.Controls.Add(this.Btn_showvalue);
            this.Controls.Add(this.btn_show_vehicles);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.textBox_listVehicles);
            this.Controls.Add(this.textBox_vehicle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Components";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vehicle;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show_vehicles;
        private System.Windows.Forms.Button Btn_showvalue;
        public System.Windows.Forms.TextBox textBox_listVehicles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListboxToolStripMenuItem;
    }
}

