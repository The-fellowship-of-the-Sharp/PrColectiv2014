using GraveyardManagement.CustomControls;

namespace GraveyardManagement.View
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStatistici = new System.Windows.Forms.TabPage();
            this.tabMorminte = new System.Windows.Forms.TabPage();
            this.tabCetateni = new System.Windows.Forms.TabPage();
            this.butonActualizareCetatean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.butonCautareCetatean = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butonAdaugareCetatean = new System.Windows.Forms.Button();
            this.gridViewCetateni = new System.Windows.Forms.DataGridView();
            this.tabDecedati = new System.Windows.Forms.TabPage();
            this.tabCereri = new System.Windows.Forms.TabPage();
            this.tabContracte = new System.Windows.Forms.TabPage();
            this.tabInmormantari = new System.Windows.Forms.TabPage();
            this.watermarkTextBox1 = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.tabControl1.SuspendLayout();
            this.tabCetateni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCetateni)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStatistici);
            this.tabControl1.Controls.Add(this.tabMorminte);
            this.tabControl1.Controls.Add(this.tabCetateni);
            this.tabControl1.Controls.Add(this.tabDecedati);
            this.tabControl1.Controls.Add(this.tabCereri);
            this.tabControl1.Controls.Add(this.tabContracte);
            this.tabControl1.Controls.Add(this.tabInmormantari);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(712, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStatistici
            // 
            this.tabStatistici.Location = new System.Drawing.Point(4, 22);
            this.tabStatistici.Name = "tabStatistici";
            this.tabStatistici.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistici.Size = new System.Drawing.Size(704, 353);
            this.tabStatistici.TabIndex = 0;
            this.tabStatistici.Text = "Statistici";
            this.tabStatistici.UseVisualStyleBackColor = true;
            // 
            // tabMorminte
            // 
            this.tabMorminte.Location = new System.Drawing.Point(4, 22);
            this.tabMorminte.Name = "tabMorminte";
            this.tabMorminte.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorminte.Size = new System.Drawing.Size(704, 353);
            this.tabMorminte.TabIndex = 1;
            this.tabMorminte.Text = "Morminte";
            this.tabMorminte.UseVisualStyleBackColor = true;
            // 
            // tabCetateni
            // 
            this.tabCetateni.Controls.Add(this.watermarkTextBox1);
            this.tabCetateni.Controls.Add(this.butonActualizareCetatean);
            this.tabCetateni.Controls.Add(this.label2);
            this.tabCetateni.Controls.Add(this.butonCautareCetatean);
            this.tabCetateni.Controls.Add(this.label1);
            this.tabCetateni.Controls.Add(this.butonAdaugareCetatean);
            this.tabCetateni.Controls.Add(this.gridViewCetateni);
            this.tabCetateni.Location = new System.Drawing.Point(4, 22);
            this.tabCetateni.Name = "tabCetateni";
            this.tabCetateni.Size = new System.Drawing.Size(704, 353);
            this.tabCetateni.TabIndex = 2;
            this.tabCetateni.Text = "Cetateni";
            this.tabCetateni.UseVisualStyleBackColor = true;
            // 
            // butonActualizareCetatean
            // 
            this.butonActualizareCetatean.Location = new System.Drawing.Point(4, 143);
            this.butonActualizareCetatean.Name = "butonActualizareCetatean";
            this.butonActualizareCetatean.Size = new System.Drawing.Size(177, 30);
            this.butonActualizareCetatean.TabIndex = 6;
            this.butonActualizareCetatean.Text = "Actualizeaza cetateanul selectat";
            this.butonActualizareCetatean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 2);
            this.label2.TabIndex = 5;
            // 
            // butonCautareCetatean
            // 
            this.butonCautareCetatean.Location = new System.Drawing.Point(163, 64);
            this.butonCautareCetatean.Name = "butonCautareCetatean";
            this.butonCautareCetatean.Size = new System.Drawing.Size(118, 30);
            this.butonCautareCetatean.TabIndex = 4;
            this.butonCautareCetatean.Text = "Cauta dupa CNP";
            this.butonCautareCetatean.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 2);
            this.label1.TabIndex = 2;
            // 
            // butonAdaugareCetatean
            // 
            this.butonAdaugareCetatean.Location = new System.Drawing.Point(4, 14);
            this.butonAdaugareCetatean.Name = "butonAdaugareCetatean";
            this.butonAdaugareCetatean.Size = new System.Drawing.Size(75, 30);
            this.butonAdaugareCetatean.TabIndex = 1;
            this.butonAdaugareCetatean.Text = "Adauga";
            this.butonAdaugareCetatean.UseVisualStyleBackColor = true;
            // 
            // gridViewCetateni
            // 
            this.gridViewCetateni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCetateni.Location = new System.Drawing.Point(317, 15);
            this.gridViewCetateni.Name = "gridViewCetateni";
            this.gridViewCetateni.Size = new System.Drawing.Size(370, 224);
            this.gridViewCetateni.TabIndex = 0;
            // 
            // tabDecedati
            // 
            this.tabDecedati.Location = new System.Drawing.Point(4, 22);
            this.tabDecedati.Name = "tabDecedati";
            this.tabDecedati.Size = new System.Drawing.Size(704, 353);
            this.tabDecedati.TabIndex = 3;
            this.tabDecedati.Text = "Decedati";
            this.tabDecedati.UseVisualStyleBackColor = true;
            // 
            // tabCereri
            // 
            this.tabCereri.Location = new System.Drawing.Point(4, 22);
            this.tabCereri.Name = "tabCereri";
            this.tabCereri.Size = new System.Drawing.Size(704, 353);
            this.tabCereri.TabIndex = 4;
            this.tabCereri.Text = "Cereri";
            this.tabCereri.UseVisualStyleBackColor = true;
            // 
            // tabContracte
            // 
            this.tabContracte.Location = new System.Drawing.Point(4, 22);
            this.tabContracte.Name = "tabContracte";
            this.tabContracte.Size = new System.Drawing.Size(704, 353);
            this.tabContracte.TabIndex = 5;
            this.tabContracte.Text = "Contracte";
            this.tabContracte.UseVisualStyleBackColor = true;
            // 
            // tabInmormantari
            // 
            this.tabInmormantari.Location = new System.Drawing.Point(4, 22);
            this.tabInmormantari.Name = "tabInmormantari";
            this.tabInmormantari.Size = new System.Drawing.Size(704, 353);
            this.tabInmormantari.TabIndex = 6;
            this.tabInmormantari.Text = "Programare Inmormantari";
            this.tabInmormantari.UseVisualStyleBackColor = true;
            // 
            // watermarkTextBox1
            // 
            this.watermarkTextBox1.Location = new System.Drawing.Point(4, 70);
            this.watermarkTextBox1.Name = "watermarkTextBox1";
            this.watermarkTextBox1.Size = new System.Drawing.Size(153, 20);
            this.watermarkTextBox1.TabIndex = 7;
            this.watermarkTextBox1.WatermarkText = "CNP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabCetateni.ResumeLayout(false);
            this.tabCetateni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCetateni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStatistici;
        private System.Windows.Forms.TabPage tabMorminte;
        private System.Windows.Forms.TabPage tabCetateni;
        private System.Windows.Forms.TabPage tabDecedati;
        private System.Windows.Forms.TabPage tabCereri;
        private System.Windows.Forms.TabPage tabContracte;
        private System.Windows.Forms.TabPage tabInmormantari;
        private System.Windows.Forms.Button butonActualizareCetatean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butonCautareCetatean;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butonAdaugareCetatean;
        private System.Windows.Forms.DataGridView gridViewCetateni;
        private WatermarkTextBox watermarkTextBox1;
    }
}