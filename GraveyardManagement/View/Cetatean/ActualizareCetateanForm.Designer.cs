namespace GraveyardManagement.View.Cetatean
{
    partial class ActualizareCetateanForm
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
            this.cnpLabel = new System.Windows.Forms.Label();
            this.localitateComboBox = new System.Windows.Forms.ComboBox();
            this.stradaTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.numarTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.detaliiTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.butonConfirma = new System.Windows.Forms.Button();
            this.butonRenunta = new System.Windows.Forms.Button();
            this.numeTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.prenumeTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(13, 84);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(35, 13);
            this.cnpLabel.TabIndex = 2;
            this.cnpLabel.Text = "label1";
            // 
            // localitateComboBox
            // 
            this.localitateComboBox.FormattingEnabled = true;
            this.localitateComboBox.Location = new System.Drawing.Point(240, 5);
            this.localitateComboBox.Name = "localitateComboBox";
            this.localitateComboBox.Size = new System.Drawing.Size(162, 21);
            this.localitateComboBox.TabIndex = 4;
            this.localitateComboBox.Text = "Localitate";
            // 
            // stradaTextBox
            // 
            this.stradaTextBox.Location = new System.Drawing.Point(240, 42);
            this.stradaTextBox.Name = "stradaTextBox";
            this.stradaTextBox.Size = new System.Drawing.Size(162, 20);
            this.stradaTextBox.TabIndex = 5;
            this.stradaTextBox.Text = "Strada Aviatorilor";
            this.stradaTextBox.WatermarkText = "";
            // 
            // numarTextBox
            // 
            this.numarTextBox.Location = new System.Drawing.Point(240, 81);
            this.numarTextBox.Name = "numarTextBox";
            this.numarTextBox.Size = new System.Drawing.Size(162, 20);
            this.numarTextBox.TabIndex = 6;
            this.numarTextBox.Text = "26";
            this.numarTextBox.WatermarkText = "";
            // 
            // detaliiTextBox
            // 
            this.detaliiTextBox.Location = new System.Drawing.Point(240, 120);
            this.detaliiTextBox.Name = "detaliiTextBox";
            this.detaliiTextBox.Size = new System.Drawing.Size(162, 20);
            this.detaliiTextBox.TabIndex = 7;
            this.detaliiTextBox.Text = "Bloc 3, Scara 4, Ap 2";
            this.detaliiTextBox.WatermarkText = "";
            // 
            // butonConfirma
            // 
            this.butonConfirma.Location = new System.Drawing.Point(297, 226);
            this.butonConfirma.Name = "butonConfirma";
            this.butonConfirma.Size = new System.Drawing.Size(105, 23);
            this.butonConfirma.TabIndex = 8;
            this.butonConfirma.Text = "Confirma";
            this.butonConfirma.UseVisualStyleBackColor = true;
            this.butonConfirma.Click += new System.EventHandler(this.butonConfirma_Click);
            // 
            // butonRenunta
            // 
            this.butonRenunta.Location = new System.Drawing.Point(161, 226);
            this.butonRenunta.Name = "butonRenunta";
            this.butonRenunta.Size = new System.Drawing.Size(105, 23);
            this.butonRenunta.TabIndex = 9;
            this.butonRenunta.Text = "Renunta";
            this.butonRenunta.UseVisualStyleBackColor = true;
            this.butonRenunta.Click += new System.EventHandler(this.butonRenunta_Click);
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(12, 6);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(162, 20);
            this.numeTextBox.TabIndex = 11;
            this.numeTextBox.Text = "Sasaran";
            this.numeTextBox.WatermarkText = "";
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(12, 42);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(162, 20);
            this.prenumeTextBox.TabIndex = 12;
            this.prenumeTextBox.Text = "Viorica";
            this.prenumeTextBox.WatermarkText = null;
            // 
            // ActualizareCetateanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.prenumeTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.butonRenunta);
            this.Controls.Add(this.butonConfirma);
            this.Controls.Add(this.detaliiTextBox);
            this.Controls.Add(this.numarTextBox);
            this.Controls.Add(this.stradaTextBox);
            this.Controls.Add(this.localitateComboBox);
            this.Controls.Add(this.cnpLabel);
            this.Name = "ActualizareCetateanForm";
            this.Text = "ActualizareCetateanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.ComboBox localitateComboBox;
        private CustomControls.WatermarkTextBox stradaTextBox;
        private CustomControls.WatermarkTextBox numarTextBox;
        private CustomControls.WatermarkTextBox detaliiTextBox;
        private System.Windows.Forms.Button butonConfirma;
        private System.Windows.Forms.Button butonRenunta;
        private CustomControls.WatermarkTextBox numeTextBox;
        private CustomControls.WatermarkTextBox prenumeTextBox;
    }
}