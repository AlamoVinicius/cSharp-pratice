
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_name = new System.Windows.Forms.Button();
            this.lb_linkGitHub = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_name
            // 
            this.btn_name.BackColor = System.Drawing.SystemColors.Info;
            this.btn_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_name.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_name.Location = new System.Drawing.Point(49, 34);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(180, 74);
            this.btn_name.TabIndex = 0;
            this.btn_name.Text = "Click on me";
            this.btn_name.UseVisualStyleBackColor = false;
            // 
            // lb_linkGitHub
            // 
            this.lb_linkGitHub.AutoSize = true;
            this.lb_linkGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_linkGitHub.Location = new System.Drawing.Point(12, 9);
            this.lb_linkGitHub.Name = "lb_linkGitHub";
            this.lb_linkGitHub.Size = new System.Drawing.Size(268, 22);
            this.lb_linkGitHub.TabIndex = 1;
            this.lb_linkGitHub.Text = "https://github.com/AlamoVinicius";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(49, 147);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(180, 20);
            this.tb_name.TabIndex = 2;
            this.tb_name.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_linkGitHub);
            this.Controls.Add(this.btn_name);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Label lb_linkGitHub;
        private System.Windows.Forms.TextBox tb_name;
    }
}

