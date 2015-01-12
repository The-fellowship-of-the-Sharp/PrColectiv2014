namespace GraveyardManagement.View.Contract
{
    partial class ActualizareContract
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
            this.Prenumelabel = new System.Windows.Forms.Label();
            this.Numelabel = new System.Windows.Forms.Label();
            this.DateEmitlabel = new System.Windows.Forms.Label();
            this.DateExplabel = new System.Windows.Forms.Label();
            this.CexpiraredateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nrChitantalabel = new System.Windows.Forms.Label();
            this.ChitantaTextBox = new System.Windows.Forms.TextBox();
            this.DataChitantalabel = new System.Windows.Forms.Label();
            this.ChitantadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateContractbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Prenumelabel
            // 
            this.Prenumelabel.AutoSize = true;
            this.Prenumelabel.Location = new System.Drawing.Point(12, 26);
            this.Prenumelabel.Name = "Prenumelabel";
            this.Prenumelabel.Size = new System.Drawing.Size(55, 13);
            this.Prenumelabel.TabIndex = 0;
            this.Prenumelabel.Text = "Prenume: ";
            // 
            // Numelabel
            // 
            this.Numelabel.AutoSize = true;
            this.Numelabel.Location = new System.Drawing.Point(12, 54);
            this.Numelabel.Name = "Numelabel";
            this.Numelabel.Size = new System.Drawing.Size(38, 13);
            this.Numelabel.TabIndex = 1;
            this.Numelabel.Text = "Nume:";
            // 
            // DateEmitlabel
            // 
            this.DateEmitlabel.AutoSize = true;
            this.DateEmitlabel.Location = new System.Drawing.Point(12, 82);
            this.DateEmitlabel.Name = "DateEmitlabel";
            this.DateEmitlabel.Size = new System.Drawing.Size(71, 13);
            this.DateEmitlabel.TabIndex = 2;
            this.DateEmitlabel.Text = "Data Emitere:";
            // 
            // DateExplabel
            // 
            this.DateExplabel.AutoSize = true;
            this.DateExplabel.Location = new System.Drawing.Point(164, 9);
            this.DateExplabel.Name = "DateExplabel";
            this.DateExplabel.Size = new System.Drawing.Size(74, 13);
            this.DateExplabel.TabIndex = 3;
            this.DateExplabel.Text = "Data Expirare:";
            // 
            // CexpiraredateTimePicker
            // 
            this.CexpiraredateTimePicker.Location = new System.Drawing.Point(167, 26);
            this.CexpiraredateTimePicker.Name = "CexpiraredateTimePicker";
            this.CexpiraredateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.CexpiraredateTimePicker.TabIndex = 4;
            // 
            // nrChitantalabel
            // 
            this.nrChitantalabel.AutoSize = true;
            this.nrChitantalabel.Location = new System.Drawing.Point(164, 64);
            this.nrChitantalabel.Name = "nrChitantalabel";
            this.nrChitantalabel.Size = new System.Drawing.Size(63, 13);
            this.nrChitantalabel.TabIndex = 5;
            this.nrChitantalabel.Text = "Nr Chitanta:";
            // 
            // ChitantaTextBox
            // 
            this.ChitantaTextBox.Location = new System.Drawing.Point(233, 61);
            this.ChitantaTextBox.Name = "ChitantaTextBox";
            this.ChitantaTextBox.Size = new System.Drawing.Size(100, 20);
            this.ChitantaTextBox.TabIndex = 6;
            // 
            // DataChitantalabel
            // 
            this.DataChitantalabel.AutoSize = true;
            this.DataChitantalabel.Location = new System.Drawing.Point(164, 92);
            this.DataChitantalabel.Name = "DataChitantalabel";
            this.DataChitantalabel.Size = new System.Drawing.Size(75, 13);
            this.DataChitantalabel.TabIndex = 7;
            this.DataChitantalabel.Text = "Data Chitanta:";
            // 
            // ChitantadateTimePicker
            // 
            this.ChitantadateTimePicker.Location = new System.Drawing.Point(245, 87);
            this.ChitantadateTimePicker.Name = "ChitantadateTimePicker";
            this.ChitantadateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.ChitantadateTimePicker.TabIndex = 8;
            // 
            // UpdateContractbutton
            // 
            this.UpdateContractbutton.Location = new System.Drawing.Point(120, 135);
            this.UpdateContractbutton.Name = "UpdateContractbutton";
            this.UpdateContractbutton.Size = new System.Drawing.Size(179, 23);
            this.UpdateContractbutton.TabIndex = 9;
            this.UpdateContractbutton.Text = "Actualizare";
            this.UpdateContractbutton.UseVisualStyleBackColor = true;
            this.UpdateContractbutton.Click += new System.EventHandler(this.UpdateContractbutton_Click);
            // 
            // ActualizareContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 180);
            this.Controls.Add(this.UpdateContractbutton);
            this.Controls.Add(this.ChitantadateTimePicker);
            this.Controls.Add(this.DataChitantalabel);
            this.Controls.Add(this.ChitantaTextBox);
            this.Controls.Add(this.nrChitantalabel);
            this.Controls.Add(this.CexpiraredateTimePicker);
            this.Controls.Add(this.DateExplabel);
            this.Controls.Add(this.DateEmitlabel);
            this.Controls.Add(this.Numelabel);
            this.Controls.Add(this.Prenumelabel);
            this.Name = "ActualizareContract";
            this.Text = "ActualizareContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Prenumelabel;
        private System.Windows.Forms.Label Numelabel;
        private System.Windows.Forms.Label DateEmitlabel;
        private System.Windows.Forms.Label DateExplabel;
        private System.Windows.Forms.DateTimePicker CexpiraredateTimePicker;
        private System.Windows.Forms.Label nrChitantalabel;
        private System.Windows.Forms.TextBox ChitantaTextBox;
        private System.Windows.Forms.Label DataChitantalabel;
        private System.Windows.Forms.DateTimePicker ChitantadateTimePicker;
        private System.Windows.Forms.Button UpdateContractbutton;
    }
}