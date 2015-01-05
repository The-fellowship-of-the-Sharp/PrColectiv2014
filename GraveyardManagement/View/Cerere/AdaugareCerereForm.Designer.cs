namespace GraveyardManagement.View.Cerere
{
    partial class AdaugareCerereForm
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
            this.cnpCetateanTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.nrInfocetTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.dataInregistrarePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.butonRenuntare = new System.Windows.Forms.Button();
            this.butonConfirmare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnpCetateanTextBox
            // 
            this.cnpCetateanTextBox.Location = new System.Drawing.Point(13, 13);
            this.cnpCetateanTextBox.Name = "cnpCetateanTextBox";
            this.cnpCetateanTextBox.Size = new System.Drawing.Size(147, 20);
            this.cnpCetateanTextBox.TabIndex = 0;
            this.cnpCetateanTextBox.WatermarkText = "CNP Cetatean";
            // 
            // nrInfocetTextBox
            // 
            this.nrInfocetTextBox.Location = new System.Drawing.Point(13, 51);
            this.nrInfocetTextBox.Name = "nrInfocetTextBox";
            this.nrInfocetTextBox.Size = new System.Drawing.Size(147, 20);
            this.nrInfocetTextBox.TabIndex = 1;
            this.nrInfocetTextBox.WatermarkText = "Numar Infocet";
            // 
            // dataInregistrarePicker
            // 
            this.dataInregistrarePicker.Location = new System.Drawing.Point(233, 36);
            this.dataInregistrarePicker.Name = "dataInregistrarePicker";
            this.dataInregistrarePicker.Size = new System.Drawing.Size(200, 20);
            this.dataInregistrarePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data inregistrare: ";
            // 
            // butonRenuntare
            // 
            this.butonRenuntare.Location = new System.Drawing.Point(219, 141);
            this.butonRenuntare.Name = "butonRenuntare";
            this.butonRenuntare.Size = new System.Drawing.Size(90, 23);
            this.butonRenuntare.TabIndex = 4;
            this.butonRenuntare.Text = "Renunta";
            this.butonRenuntare.UseVisualStyleBackColor = true;
            this.butonRenuntare.Click += new System.EventHandler(this.butonRenuntare_Click);
            // 
            // butonConfirmare
            // 
            this.butonConfirmare.Location = new System.Drawing.Point(329, 141);
            this.butonConfirmare.Name = "butonConfirmare";
            this.butonConfirmare.Size = new System.Drawing.Size(90, 23);
            this.butonConfirmare.TabIndex = 5;
            this.butonConfirmare.Text = "Confirma";
            this.butonConfirmare.UseVisualStyleBackColor = true;
            this.butonConfirmare.Click += new System.EventHandler(this.butonConfirmare_Click);
            // 
            // AdaugareCerereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 175);
            this.Controls.Add(this.butonConfirmare);
            this.Controls.Add(this.butonRenuntare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataInregistrarePicker);
            this.Controls.Add(this.nrInfocetTextBox);
            this.Controls.Add(this.cnpCetateanTextBox);
            this.Name = "AdaugareCerereForm";
            this.Text = "Adaugare Cerere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.WatermarkTextBox cnpCetateanTextBox;
        private CustomControls.WatermarkTextBox nrInfocetTextBox;
        private System.Windows.Forms.DateTimePicker dataInregistrarePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonRenuntare;
        private System.Windows.Forms.Button butonConfirmare;
    }
}