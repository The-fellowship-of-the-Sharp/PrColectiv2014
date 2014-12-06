namespace GraveyardManagement.View.Cetatean
{
    partial class AdaugareCetateanForm
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
            this.numeTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.prenumeTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.cnpTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.localitateComboBox = new System.Windows.Forms.ComboBox();
            this.stradaTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.numarTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.detaliiTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.butonConfirma = new System.Windows.Forms.Button();
            this.butonRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(13, 13);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(159, 20);
            this.numeTextBox.TabIndex = 0;
            this.numeTextBox.WatermarkText = "Nume";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(12, 51);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(159, 20);
            this.prenumeTextBox.TabIndex = 1;
            this.prenumeTextBox.WatermarkText = "Prenume";
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(12, 89);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(159, 20);
            this.cnpTextBox.TabIndex = 2;
            this.cnpTextBox.WatermarkText = "CNP";
            // 
            // localitateComboBox
            // 
            this.localitateComboBox.FormattingEnabled = true;
            this.localitateComboBox.Location = new System.Drawing.Point(240, 11);
            this.localitateComboBox.Name = "localitateComboBox";
            this.localitateComboBox.Size = new System.Drawing.Size(162, 21);
            this.localitateComboBox.TabIndex = 3;
            this.localitateComboBox.Text = "Localitate";
            // 
            // stradaTextBox
            // 
            this.stradaTextBox.Location = new System.Drawing.Point(240, 51);
            this.stradaTextBox.Name = "stradaTextBox";
            this.stradaTextBox.Size = new System.Drawing.Size(162, 20);
            this.stradaTextBox.TabIndex = 4;
            this.stradaTextBox.WatermarkText = "Strada";
            // 
            // numarTextBox
            // 
            this.numarTextBox.Location = new System.Drawing.Point(240, 89);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(162, 20);
            this.numarTextBox.TabIndex = 5;
            this.numarTextBox.WatermarkText = "Numar";
            // 
            // detaliiTextBox
            // 
            this.detaliiTextBox.Location = new System.Drawing.Point(240, 129);
            this.detaliiTextBox.Name = "detaliiTextBox";
            this.detaliiTextBox.Size = new System.Drawing.Size(162, 20);
            this.detaliiTextBox.TabIndex = 6;
            this.detaliiTextBox.WatermarkText = "Alte detalii";
            // 
            // butonConfirma
            // 
            this.butonConfirma.Location = new System.Drawing.Point(297, 226);
            this.butonConfirma.Name = "butonConfirma";
            this.butonConfirma.Size = new System.Drawing.Size(105, 23);
            this.butonConfirma.TabIndex = 7;
            this.butonConfirma.Text = "Confirma";
            this.butonConfirma.UseVisualStyleBackColor = true;
            this.butonConfirma.Click += new System.EventHandler(this.butonConfirma_Click);
            // 
            // butonRenunta
            // 
            this.butonRenunta.Location = new System.Drawing.Point(155, 226);
            this.butonRenunta.Name = "butonRenunta";
            this.butonRenunta.Size = new System.Drawing.Size(105, 23);
            this.butonRenunta.TabIndex = 8;
            this.butonRenunta.Text = "Renunta";
            this.butonRenunta.UseVisualStyleBackColor = true;
            this.butonRenunta.Click += new System.EventHandler(this.butonRenunta_Click);
            // 
            // AdaugareCetateanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.butonRenunta);
            this.Controls.Add(this.butonConfirma);
            this.Controls.Add(this.detaliiTextBox);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.stradaTextBox);
            this.Controls.Add(this.localitateComboBox);
            this.Controls.Add(this.cnpTextBox);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Name = "AdaugareCetateanForm";
            this.Text = "AdaugareCetateanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.WatermarkTextBox numeTextBox;
        private CustomControls.WatermarkTextBox prenumeTextBox;
        private CustomControls.WatermarkTextBox cnpTextBox;
        private System.Windows.Forms.ComboBox localitateComboBox;
        private CustomControls.WatermarkTextBox stradaTextBox;
        private CustomControls.WatermarkTextBox numarTextBox;
        private CustomControls.WatermarkTextBox detaliiTextBox;
        private System.Windows.Forms.Button butonConfirma;
        private System.Windows.Forms.Button butonRenunta;
    }
}