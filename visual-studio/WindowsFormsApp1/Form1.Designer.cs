
namespace WindowsFormsApp1
{
    partial class Main_form
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
            this.btn_text = new System.Windows.Forms.Button();
            this.lb_text = new System.Windows.Forms.Label();
            this.Text_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.SystemColors.Info;
            this.btn_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_text.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_text.Location = new System.Drawing.Point(12, 77);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(264, 74);
            this.btn_text.TabIndex = 0;
            this.btn_text.Text = "Click on me";
            this.btn_text.UseVisualStyleBackColor = false;
            this.btn_text.Click += new System.EventHandler(this.Btn_text_Click);
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.Location = new System.Drawing.Point(8, 164);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(268, 22);
            this.lb_text.TabIndex = 1;
            this.lb_text.Text = "https://github.com/AlamoVinicius";
            // 
            // Text_box
            // 
            this.Text_box.Location = new System.Drawing.Point(12, 25);
            this.Text_box.Multiline = true;
            this.Text_box.Name = "Text_box";
            this.Text_box.Size = new System.Drawing.Size(264, 28);
            this.Text_box.TabIndex = 2;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text_box);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.btn_text);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Main_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_text;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.TextBox Text_box;
    }
}

