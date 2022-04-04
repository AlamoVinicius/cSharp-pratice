
namespace TectBoxComponents
{
    partial class Form_checkedListBox
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
            System.Windows.Forms.Button Btn_showSelected;
            this.checkedListBox_transports = new System.Windows.Forms.CheckedListBox();
            this.Btn_clearList = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.Btn_addNewTransport = new System.Windows.Forms.Button();
            this.textBox_addNewTransport = new System.Windows.Forms.TextBox();
            this.Label_addNewTransport = new System.Windows.Forms.Label();
            Btn_showSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_showSelected
            // 
            Btn_showSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            Btn_showSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Btn_showSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Btn_showSelected.ForeColor = System.Drawing.SystemColors.Desktop;
            Btn_showSelected.Location = new System.Drawing.Point(174, 28);
            Btn_showSelected.Name = "Btn_showSelected";
            Btn_showSelected.Size = new System.Drawing.Size(221, 35);
            Btn_showSelected.TabIndex = 1;
            Btn_showSelected.Text = "Mostrar selecionados";
            Btn_showSelected.UseVisualStyleBackColor = true;
            Btn_showSelected.Click += new System.EventHandler(this.Btn_showSelected_Click);
            // 
            // checkedListBox_transports
            // 
            this.checkedListBox_transports.FormattingEnabled = true;
            this.checkedListBox_transports.Items.AddRange(new object[] {
            "CARRO",
            "AVIÃO",
            "NAVIO",
            "ÔNIBUS",
            "TREM"});
            this.checkedListBox_transports.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox_transports.Name = "checkedListBox_transports";
            this.checkedListBox_transports.Size = new System.Drawing.Size(156, 244);
            this.checkedListBox_transports.TabIndex = 0;
            // 
            // Btn_clearList
            // 
            this.Btn_clearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_clearList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_clearList.Location = new System.Drawing.Point(174, 69);
            this.Btn_clearList.Name = "Btn_clearList";
            this.Btn_clearList.Size = new System.Drawing.Size(221, 34);
            this.Btn_clearList.TabIndex = 2;
            this.Btn_clearList.Text = "Limpar lista";
            this.Btn_clearList.UseVisualStyleBackColor = true;
            this.Btn_clearList.Click += new System.EventHandler(this.Btn_clearList_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_reset.Location = new System.Drawing.Point(174, 109);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(221, 35);
            this.Btn_reset.TabIndex = 3;
            this.Btn_reset.Text = "Resetar lista";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Btn_addNewTransport
            // 
            this.Btn_addNewTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_addNewTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_addNewTransport.Location = new System.Drawing.Point(184, 218);
            this.Btn_addNewTransport.Name = "Btn_addNewTransport";
            this.Btn_addNewTransport.Size = new System.Drawing.Size(221, 35);
            this.Btn_addNewTransport.TabIndex = 4;
            this.Btn_addNewTransport.Text = "Adicionar novo transporte";
            this.Btn_addNewTransport.UseVisualStyleBackColor = true;
            this.Btn_addNewTransport.Click += new System.EventHandler(this.Btn_addNewTransport_Click);
            // 
            // textBox_addNewTransport
            // 
            this.textBox_addNewTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addNewTransport.Location = new System.Drawing.Point(184, 192);
            this.textBox_addNewTransport.Name = "textBox_addNewTransport";
            this.textBox_addNewTransport.Size = new System.Drawing.Size(221, 23);
            this.textBox_addNewTransport.TabIndex = 5;
            // 
            // Label_addNewTransport
            // 
            this.Label_addNewTransport.AutoSize = true;
            this.Label_addNewTransport.Location = new System.Drawing.Point(184, 173);
            this.Label_addNewTransport.Name = "Label_addNewTransport";
            this.Label_addNewTransport.Size = new System.Drawing.Size(131, 13);
            this.Label_addNewTransport.TabIndex = 6;
            this.Label_addNewTransport.Text = "Digite um novo transporte:";
            // 
            // Form_checkedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 430);
            this.Controls.Add(this.Label_addNewTransport);
            this.Controls.Add(this.textBox_addNewTransport);
            this.Controls.Add(this.Btn_addNewTransport);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_clearList);
            this.Controls.Add(Btn_showSelected);
            this.Controls.Add(this.checkedListBox_transports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_checkedListBox";
            this.Text = "checkedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_transports;
        private System.Windows.Forms.Button Btn_clearList;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Button Btn_addNewTransport;
        private System.Windows.Forms.TextBox textBox_addNewTransport;
        private System.Windows.Forms.Label Label_addNewTransport;
    }
}