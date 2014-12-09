namespace GraveyardManagement.View.ProgramareInmormantari
{
    partial class ActualizeazaProgramareForm
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
            this.confirmaButton = new System.Windows.Forms.Button();
            this.renuntaButton = new System.Windows.Forms.Button();
            this.religieComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.numarMormantTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.parcelaTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.cimitirComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // confirmaButton
            // 
            this.confirmaButton.Location = new System.Drawing.Point(169, 134);
            this.confirmaButton.Name = "confirmaButton";
            this.confirmaButton.Size = new System.Drawing.Size(100, 23);
            this.confirmaButton.TabIndex = 15;
            this.confirmaButton.Text = "Confirma";
            this.confirmaButton.UseVisualStyleBackColor = true;
            // 
            // renuntaButton
            // 
            this.renuntaButton.Location = new System.Drawing.Point(57, 133);
            this.renuntaButton.Name = "renuntaButton";
            this.renuntaButton.Size = new System.Drawing.Size(106, 24);
            this.renuntaButton.TabIndex = 14;
            this.renuntaButton.Text = "Renunta";
            this.renuntaButton.UseVisualStyleBackColor = true;
            // 
            // religieComboBox
            // 
            this.religieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.religieComboBox.FormattingEnabled = true;
            this.religieComboBox.Location = new System.Drawing.Point(88, 86);
            this.religieComboBox.Name = "religieComboBox";
            this.religieComboBox.Size = new System.Drawing.Size(156, 21);
            this.religieComboBox.TabIndex = 13;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(169, 47);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(156, 20);
            this.datePicker.TabIndex = 12;
            // 
            // numarMormantTextBox
            // 
            this.numarMormantTextBox.Location = new System.Drawing.Point(169, 12);
            this.numarMormantTextBox.Name = "numarMormantTextBox";
            this.numarMormantTextBox.Size = new System.Drawing.Size(156, 20);
            this.numarMormantTextBox.TabIndex = 11;
            this.numarMormantTextBox.WatermarkText = "Numar mormant";
            // 
            // parcelaTextBox
            // 
            this.parcelaTextBox.Location = new System.Drawing.Point(12, 47);
            this.parcelaTextBox.Name = "parcelaTextBox";
            this.parcelaTextBox.Size = new System.Drawing.Size(151, 20);
            this.parcelaTextBox.TabIndex = 10;
            this.parcelaTextBox.WatermarkText = "Parcela";
            // 
            // cimitirComboBox
            // 
            this.cimitirComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cimitirComboBox.FormattingEnabled = true;
            this.cimitirComboBox.Location = new System.Drawing.Point(12, 12);
            this.cimitirComboBox.Name = "cimitirComboBox";
            this.cimitirComboBox.Size = new System.Drawing.Size(151, 21);
            this.cimitirComboBox.TabIndex = 9;
            // 
            // ActualizeazaProgramareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 166);
            this.Controls.Add(this.confirmaButton);
            this.Controls.Add(this.renuntaButton);
            this.Controls.Add(this.religieComboBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.numarMormantTextBox);
            this.Controls.Add(this.parcelaTextBox);
            this.Controls.Add(this.cimitirComboBox);
            this.Name = "ActualizeazaProgramareForm";
            this.Text = "ActualizeazaProgramare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmaButton;
        private System.Windows.Forms.Button renuntaButton;
        private System.Windows.Forms.ComboBox religieComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private CustomControls.WatermarkTextBox numarMormantTextBox;
        private CustomControls.WatermarkTextBox parcelaTextBox;
        private System.Windows.Forms.ComboBox cimitirComboBox;

    }
}