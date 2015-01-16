namespace GraveyardManagement.View.Mormant
{
    partial class AdaugaMormant
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
            this.cimitirCombo = new System.Windows.Forms.ComboBox();
            this.parcelaTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.numarTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.monumentCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cimitirCombo
            // 
            this.cimitirCombo.FormattingEnabled = true;
            this.cimitirCombo.Location = new System.Drawing.Point(12, 12);
            this.cimitirCombo.Name = "cimitirCombo";
            this.cimitirCombo.Size = new System.Drawing.Size(121, 21);
            this.cimitirCombo.TabIndex = 0;
            this.cimitirCombo.Text = "Cimitir";
            // 
            // parcelaTextBox
            // 
            this.parcelaTextBox.Location = new System.Drawing.Point(12, 39);
            this.parcelaTextBox.Name = "parcelaTextBox";
            this.parcelaTextBox.Size = new System.Drawing.Size(121, 20);
            this.parcelaTextBox.TabIndex = 1;
            this.parcelaTextBox.WatermarkText = "Parcela";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 102);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Renunta";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(182, 102);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirma";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // numarTextBox
            // 
            this.numarTextBox.Location = new System.Drawing.Point(12, 66);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(121, 20);
            this.numarTextBox.TabIndex = 4;
            this.numarTextBox.WatermarkText = "Numar";
            // 
            // monumentCheckBox
            // 
            this.monumentCheckBox.AutoSize = true;
            this.monumentCheckBox.Location = new System.Drawing.Point(182, 12);
            this.monumentCheckBox.Name = "monumentCheckBox";
            this.monumentCheckBox.Size = new System.Drawing.Size(99, 17);
            this.monumentCheckBox.TabIndex = 5;
            this.monumentCheckBox.Text = "Este monument";
            this.monumentCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdaugaMormant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 137);
            this.Controls.Add(this.monumentCheckBox);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.parcelaTextBox);
            this.Controls.Add(this.cimitirCombo);
            this.Name = "AdaugaMormant";
            this.Text = "AdaugaMormant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cimitirCombo;
        private CustomControls.WatermarkTextBox parcelaTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private CustomControls.WatermarkTextBox numarTextBox;
        private System.Windows.Forms.CheckBox monumentCheckBox;
    }
}