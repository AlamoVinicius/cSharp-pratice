
namespace TectBoxComponents
{
    partial class Form_dateTimePicker
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
            this.DateTimePicker_data = new System.Windows.Forms.DateTimePicker();
            this.Btn_getData = new System.Windows.Forms.Button();
            this.TextBox_data = new System.Windows.Forms.TextBox();
            this.TextBox_day = new System.Windows.Forms.TextBox();
            this.textBox_mounth = new System.Windows.Forms.TextBox();
            this.TextBox_year = new System.Windows.Forms.TextBox();
            this.Btn_SetData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTimePicker_data
            // 
            this.DateTimePicker_data.Location = new System.Drawing.Point(13, 13);
            this.DateTimePicker_data.Name = "DateTimePicker_data";
            this.DateTimePicker_data.Size = new System.Drawing.Size(312, 20);
            this.DateTimePicker_data.TabIndex = 0;
            // 
            // Btn_getData
            // 
            this.Btn_getData.Location = new System.Drawing.Point(331, 9);
            this.Btn_getData.Name = "Btn_getData";
            this.Btn_getData.Size = new System.Drawing.Size(228, 23);
            this.Btn_getData.TabIndex = 1;
            this.Btn_getData.Text = "Obter data";
            this.Btn_getData.UseVisualStyleBackColor = true;
            this.Btn_getData.Click += new System.EventHandler(this.Btn_getData_Click);
            // 
            // TextBox_data
            // 
            this.TextBox_data.Location = new System.Drawing.Point(13, 40);
            this.TextBox_data.Name = "TextBox_data";
            this.TextBox_data.Size = new System.Drawing.Size(312, 20);
            this.TextBox_data.TabIndex = 2;
            // 
            // TextBox_day
            // 
            this.TextBox_day.Location = new System.Drawing.Point(13, 67);
            this.TextBox_day.Name = "TextBox_day";
            this.TextBox_day.Size = new System.Drawing.Size(100, 20);
            this.TextBox_day.TabIndex = 3;
            // 
            // textBox_mounth
            // 
            this.textBox_mounth.Location = new System.Drawing.Point(119, 66);
            this.textBox_mounth.Name = "textBox_mounth";
            this.textBox_mounth.Size = new System.Drawing.Size(100, 20);
            this.textBox_mounth.TabIndex = 4;
            // 
            // TextBox_year
            // 
            this.TextBox_year.Location = new System.Drawing.Point(225, 66);
            this.TextBox_year.Name = "TextBox_year";
            this.TextBox_year.Size = new System.Drawing.Size(100, 20);
            this.TextBox_year.TabIndex = 5;
            // 
            // Btn_SetData
            // 
            this.Btn_SetData.Location = new System.Drawing.Point(331, 67);
            this.Btn_SetData.Name = "Btn_SetData";
            this.Btn_SetData.Size = new System.Drawing.Size(227, 23);
            this.Btn_SetData.TabIndex = 9;
            this.Btn_SetData.Text = "Configurar data";
            this.Btn_SetData.UseVisualStyleBackColor = true;
            this.Btn_SetData.Click += new System.EventHandler(this.Btn_SetData_Click);
            // 
            // Form_dateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.Btn_SetData);
            this.Controls.Add(this.TextBox_year);
            this.Controls.Add(this.textBox_mounth);
            this.Controls.Add(this.TextBox_day);
            this.Controls.Add(this.TextBox_data);
            this.Controls.Add(this.Btn_getData);
            this.Controls.Add(this.DateTimePicker_data);
            this.Name = "Form_dateTimePicker";
            this.Text = "Form_dateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker_data;
        private System.Windows.Forms.Button Btn_getData;
        private System.Windows.Forms.TextBox TextBox_data;
        private System.Windows.Forms.TextBox TextBox_day;
        private System.Windows.Forms.TextBox textBox_mounth;
        private System.Windows.Forms.TextBox TextBox_year;
        private System.Windows.Forms.Button Btn_SetData;
    }
}