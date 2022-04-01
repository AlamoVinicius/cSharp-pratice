
namespace TectBoxComponents
{
    partial class Form_Vehicles
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
            this.textBox_vehiclielist = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_vehiclielist
            // 
            this.textBox_vehiclielist.Location = new System.Drawing.Point(12, 12);
            this.textBox_vehiclielist.Multiline = true;
            this.textBox_vehiclielist.Name = "textBox_vehiclielist";
            this.textBox_vehiclielist.Size = new System.Drawing.Size(409, 426);
            this.textBox_vehiclielist.TabIndex = 0;
            // 
            // Form_Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.textBox_vehiclielist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Vehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Vehicles_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_vehiclielist;
    }
}