
namespace TectBoxComponents
{
    partial class comboBox
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
            this.ComboBox_transports = new System.Windows.Forms.ComboBox();
            this.Btn_showSelected = new System.Windows.Forms.Button();
            this.Btn_clearElements = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.TextBox_addnewTransport = new System.Windows.Forms.TextBox();
            this.Btn_addnewTransport = new System.Windows.Forms.Button();
            this.label_addNewTransport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ComboBox_transports
            // 
            this.ComboBox_transports.FormattingEnabled = true;
            this.ComboBox_transports.Items.AddRange(new object[] {
            "CARRO",
            "AVIÃO",
            "NAVIO",
            "ÔNIBUS",
            "TREM"});
            this.ComboBox_transports.Location = new System.Drawing.Point(13, 13);
            this.ComboBox_transports.Name = "ComboBox_transports";
            this.ComboBox_transports.Size = new System.Drawing.Size(202, 21);
            this.ComboBox_transports.TabIndex = 0;
            this.ComboBox_transports.SelectedIndexChanged += new System.EventHandler(this.ComboBox_transports_SelectedIndexChanged);
            // 
            // Btn_showSelected
            // 
            this.Btn_showSelected.Location = new System.Drawing.Point(221, 11);
            this.Btn_showSelected.Name = "Btn_showSelected";
            this.Btn_showSelected.Size = new System.Drawing.Size(226, 23);
            this.Btn_showSelected.TabIndex = 1;
            this.Btn_showSelected.Text = "Mostrar selecionados";
            this.Btn_showSelected.UseVisualStyleBackColor = true;
            this.Btn_showSelected.Click += new System.EventHandler(this.Btn_showSelected_Click);
            // 
            // Btn_clearElements
            // 
            this.Btn_clearElements.Location = new System.Drawing.Point(221, 40);
            this.Btn_clearElements.Name = "Btn_clearElements";
            this.Btn_clearElements.Size = new System.Drawing.Size(226, 23);
            this.Btn_clearElements.TabIndex = 2;
            this.Btn_clearElements.Text = "Limpar elementos";
            this.Btn_clearElements.UseVisualStyleBackColor = true;
            this.Btn_clearElements.Click += new System.EventHandler(this.Btn_clearElements_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(221, 69);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(226, 23);
            this.Btn_reset.TabIndex = 3;
            this.Btn_reset.Text = "Resetar elementos";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // TextBox_addnewTransport
            // 
            this.TextBox_addnewTransport.Location = new System.Drawing.Point(221, 129);
            this.TextBox_addnewTransport.Name = "TextBox_addnewTransport";
            this.TextBox_addnewTransport.Size = new System.Drawing.Size(226, 20);
            this.TextBox_addnewTransport.TabIndex = 4;
            // 
            // Btn_addnewTransport
            // 
            this.Btn_addnewTransport.Location = new System.Drawing.Point(221, 155);
            this.Btn_addnewTransport.Name = "Btn_addnewTransport";
            this.Btn_addnewTransport.Size = new System.Drawing.Size(226, 23);
            this.Btn_addnewTransport.TabIndex = 5;
            this.Btn_addnewTransport.Text = "adicionar";
            this.Btn_addnewTransport.UseVisualStyleBackColor = true;
            this.Btn_addnewTransport.Click += new System.EventHandler(this.Btn_addnewTransport_Click);
            // 
            // label_addNewTransport
            // 
            this.label_addNewTransport.AutoSize = true;
            this.label_addNewTransport.Location = new System.Drawing.Point(221, 110);
            this.label_addNewTransport.Name = "label_addNewTransport";
            this.label_addNewTransport.Size = new System.Drawing.Size(128, 13);
            this.label_addNewTransport.TabIndex = 6;
            this.label_addNewTransport.Text = "Adicionar novo transporte";
            // 
            // comboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.label_addNewTransport);
            this.Controls.Add(this.Btn_addnewTransport);
            this.Controls.Add(this.TextBox_addnewTransport);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_clearElements);
            this.Controls.Add(this.Btn_showSelected);
            this.Controls.Add(this.ComboBox_transports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "comboBox";
            this.Text = "Form_comboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBox_transports;
        private System.Windows.Forms.Button Btn_showSelected;
        private System.Windows.Forms.Button Btn_clearElements;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.TextBox TextBox_addnewTransport;
        private System.Windows.Forms.Button Btn_addnewTransport;
        private System.Windows.Forms.Label label_addNewTransport;
    }
}