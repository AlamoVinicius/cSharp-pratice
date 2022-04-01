
namespace TectBoxComponents
{
    partial class Form_checkBox
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
            this.checkBox_carro = new System.Windows.Forms.CheckBox();
            this.checkBox_aviao = new System.Windows.Forms.CheckBox();
            this.checkBox_moto = new System.Windows.Forms.CheckBox();
            this.checkBox_onibus = new System.Windows.Forms.CheckBox();
            this.Btn_checkedtransps = new System.Windows.Forms.Button();
            this.checkBox_skate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox_carro
            // 
            this.checkBox_carro.AutoSize = true;
            this.checkBox_carro.Location = new System.Drawing.Point(13, 13);
            this.checkBox_carro.Name = "checkBox_carro";
            this.checkBox_carro.Size = new System.Drawing.Size(51, 17);
            this.checkBox_carro.TabIndex = 0;
            this.checkBox_carro.Text = "Carro";
            this.checkBox_carro.UseVisualStyleBackColor = true;
            // 
            // checkBox_aviao
            // 
            this.checkBox_aviao.AutoSize = true;
            this.checkBox_aviao.Location = new System.Drawing.Point(13, 37);
            this.checkBox_aviao.Name = "checkBox_aviao";
            this.checkBox_aviao.Size = new System.Drawing.Size(53, 17);
            this.checkBox_aviao.TabIndex = 1;
            this.checkBox_aviao.Text = "Avião";
            this.checkBox_aviao.UseVisualStyleBackColor = true;
            // 
            // checkBox_moto
            // 
            this.checkBox_moto.AutoSize = true;
            this.checkBox_moto.Location = new System.Drawing.Point(13, 61);
            this.checkBox_moto.Name = "checkBox_moto";
            this.checkBox_moto.Size = new System.Drawing.Size(81, 17);
            this.checkBox_moto.TabIndex = 2;
            this.checkBox_moto.Text = "Motocicleta";
            this.checkBox_moto.UseVisualStyleBackColor = true;
            // 
            // checkBox_onibus
            // 
            this.checkBox_onibus.AutoSize = true;
            this.checkBox_onibus.Location = new System.Drawing.Point(13, 85);
            this.checkBox_onibus.Name = "checkBox_onibus";
            this.checkBox_onibus.Size = new System.Drawing.Size(59, 17);
            this.checkBox_onibus.TabIndex = 3;
            this.checkBox_onibus.Text = "Ônibus";
            this.checkBox_onibus.UseVisualStyleBackColor = true;
            // 
            // Btn_checkedtransps
            // 
            this.Btn_checkedtransps.Location = new System.Drawing.Point(115, 13);
            this.Btn_checkedtransps.Name = "Btn_checkedtransps";
            this.Btn_checkedtransps.Size = new System.Drawing.Size(212, 23);
            this.Btn_checkedtransps.TabIndex = 4;
            this.Btn_checkedtransps.Text = "transportes marcados";
            this.Btn_checkedtransps.UseVisualStyleBackColor = true;
            this.Btn_checkedtransps.Click += new System.EventHandler(this.Btn_checkedtransps_Click);
            // 
            // checkBox_skate
            // 
            this.checkBox_skate.AutoSize = true;
            this.checkBox_skate.Location = new System.Drawing.Point(13, 186);
            this.checkBox_skate.Name = "checkBox_skate";
            this.checkBox_skate.Size = new System.Drawing.Size(52, 17);
            this.checkBox_skate.TabIndex = 5;
            this.checkBox_skate.Text = "skate";
            this.checkBox_skate.UseVisualStyleBackColor = true;
            this.checkBox_skate.CheckedChanged += new System.EventHandler(this.checkBox_skate_CheckedChanged);
            // 
            // Form_checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.checkBox_skate);
            this.Controls.Add(this.Btn_checkedtransps);
            this.Controls.Add(this.checkBox_onibus);
            this.Controls.Add(this.checkBox_moto);
            this.Controls.Add(this.checkBox_aviao);
            this.Controls.Add(this.checkBox_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_checkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_carro;
        private System.Windows.Forms.CheckBox checkBox_aviao;
        private System.Windows.Forms.CheckBox checkBox_moto;
        private System.Windows.Forms.CheckBox checkBox_onibus;
        private System.Windows.Forms.Button Btn_checkedtransps;
        private System.Windows.Forms.CheckBox checkBox_skate;
    }
}