namespace GraveyardManagement.View.Decedat
{
    partial class AtribuireMormant
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
            this.label1 = new System.Windows.Forms.Label();
            this.cimitirCombo = new System.Windows.Forms.ComboBox();
            this.watermarkTextBox1 = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.watermarkTextBox2 = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Suprafata = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // cimitirCombo
            // 
            this.cimitirCombo.FormattingEnabled = true;
            this.cimitirCombo.Location = new System.Drawing.Point(12, 70);
            this.cimitirCombo.Name = "cimitirCombo";
            this.cimitirCombo.Size = new System.Drawing.Size(183, 21);
            this.cimitirCombo.TabIndex = 1;
            this.cimitirCombo.Text = "Cimitir";
            // 
            // watermarkTextBox1
            // 
            this.watermarkTextBox1.Location = new System.Drawing.Point(12, 97);
            this.watermarkTextBox1.Name = "watermarkTextBox1";
            this.watermarkTextBox1.Size = new System.Drawing.Size(183, 20);
            this.watermarkTextBox1.TabIndex = 2;
            this.watermarkTextBox1.WatermarkText = "Parcela";
            // 
            // watermarkTextBox2
            // 
            this.watermarkTextBox2.Location = new System.Drawing.Point(12, 123);
            this.watermarkTextBox2.Name = "watermarkTextBox2";
            this.watermarkTextBox2.Size = new System.Drawing.Size(183, 20);
            this.watermarkTextBox2.TabIndex = 3;
            this.watermarkTextBox2.WatermarkText = "Numar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Renunta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_Suprafata
            // 
            this.txt_Suprafata.Location = new System.Drawing.Point(12, 149);
            this.txt_Suprafata.Name = "txt_Suprafata";
            this.txt_Suprafata.Size = new System.Drawing.Size(183, 20);
            this.txt_Suprafata.TabIndex = 6;
            this.txt_Suprafata.WatermarkText = "Suprafata";
            // 
            // AtribuireMormant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 238);
            this.Controls.Add(this.txt_Suprafata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.watermarkTextBox2);
            this.Controls.Add(this.watermarkTextBox1);
            this.Controls.Add(this.cimitirCombo);
            this.Controls.Add(this.label1);
            this.Name = "AtribuireMormant";
            this.Text = "Atribuire Mormant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cimitirCombo;
        private CustomControls.WatermarkTextBox watermarkTextBox1;
        private CustomControls.WatermarkTextBox watermarkTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private CustomControls.WatermarkTextBox txt_Suprafata;
    }
}