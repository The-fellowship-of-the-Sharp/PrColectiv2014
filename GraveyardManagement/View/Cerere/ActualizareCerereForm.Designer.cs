namespace GraveyardManagement.View.Cerere
{
    partial class ActualizareCerereForm
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
            this.cnpCetateanLabel = new System.Windows.Forms.Label();
            this.nrInfocetLabel = new System.Windows.Forms.Label();
            this.dataInregistrareLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stadiuComboBox = new System.Windows.Forms.ComboBox();
            this.butonRenuntare = new System.Windows.Forms.Button();
            this.butonConfirmare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cnpCetateanLabel
            // 
            this.cnpCetateanLabel.AutoSize = true;
            this.cnpCetateanLabel.Location = new System.Drawing.Point(13, 13);
            this.cnpCetateanLabel.Name = "cnpCetateanLabel";
            this.cnpCetateanLabel.Size = new System.Drawing.Size(84, 13);
            this.cnpCetateanLabel.TabIndex = 0;
            this.cnpCetateanLabel.Text = "CNP Cetatean:  ";
            // 
            // nrInfocetLabel
            // 
            this.nrInfocetLabel.AutoSize = true;
            this.nrInfocetLabel.Location = new System.Drawing.Point(13, 44);
            this.nrInfocetLabel.Name = "nrInfocetLabel";
            this.nrInfocetLabel.Size = new System.Drawing.Size(80, 13);
            this.nrInfocetLabel.TabIndex = 1;
            this.nrInfocetLabel.Text = "Numar Infocet: ";
            // 
            // dataInregistrareLabel
            // 
            this.dataInregistrareLabel.AutoSize = true;
            this.dataInregistrareLabel.Location = new System.Drawing.Point(13, 76);
            this.dataInregistrareLabel.Name = "dataInregistrareLabel";
            this.dataInregistrareLabel.Size = new System.Drawing.Size(91, 13);
            this.dataInregistrareLabel.TabIndex = 2;
            this.dataInregistrareLabel.Text = "Data Inregistrare: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stadiu: ";
            // 
            // stadiuComboBox
            // 
            this.stadiuComboBox.FormattingEnabled = true;
            this.stadiuComboBox.Location = new System.Drawing.Point(267, 36);
            this.stadiuComboBox.Name = "stadiuComboBox";
            this.stadiuComboBox.Size = new System.Drawing.Size(152, 21);
            this.stadiuComboBox.TabIndex = 4;
            // 
            // butonRenuntare
            // 
            this.butonRenuntare.Location = new System.Drawing.Point(211, 141);
            this.butonRenuntare.Name = "butonRenuntare";
            this.butonRenuntare.Size = new System.Drawing.Size(90, 23);
            this.butonRenuntare.TabIndex = 5;
            this.butonRenuntare.Text = "Renunta";
            this.butonRenuntare.UseVisualStyleBackColor = true;
            this.butonRenuntare.Click += new System.EventHandler(this.butonRenuntare_Click);
            // 
            // butonConfirmare
            // 
            this.butonConfirmare.Location = new System.Drawing.Point(319, 140);
            this.butonConfirmare.Name = "butonConfirmare";
            this.butonConfirmare.Size = new System.Drawing.Size(90, 23);
            this.butonConfirmare.TabIndex = 6;
            this.butonConfirmare.Text = "Confirma";
            this.butonConfirmare.UseVisualStyleBackColor = true;
            this.butonConfirmare.Click += new System.EventHandler(this.butonConfirmare_Click);
            // 
            // ActualizareCerereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.butonConfirmare);
            this.Controls.Add(this.butonRenuntare);
            this.Controls.Add(this.stadiuComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataInregistrareLabel);
            this.Controls.Add(this.nrInfocetLabel);
            this.Controls.Add(this.cnpCetateanLabel);
            this.Name = "ActualizareCerereForm";
            this.Text = "Actualizare Cerere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cnpCetateanLabel;
        private System.Windows.Forms.Label nrInfocetLabel;
        private System.Windows.Forms.Label dataInregistrareLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stadiuComboBox;
        private System.Windows.Forms.Button butonRenuntare;
        private System.Windows.Forms.Button butonConfirmare;
    }
}