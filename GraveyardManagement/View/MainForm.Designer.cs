﻿using GraveyardManagement.CustomControls;

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
            this.components = new System.ComponentModel.Container();
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
            this.programariView = new System.Windows.Forms.DataGridView();
            this.cnpDecedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDecedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDecedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimitirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarMormantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programareInmormantareDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stergeButton = new System.Windows.Forms.Button();
            this.actualizaButton = new System.Windows.Forms.Button();
            this.cautaInIntervalButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cautaDupaDecedatButton = new System.Windows.Forms.Button();
            this.cnpTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.textBoxCnpCetatean = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.tabControl1.SuspendLayout();
            this.tabCetateni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCetateni)).BeginInit();
            this.tabInmormantari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programariView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programareInmormantareDTOBindingSource)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(901, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStatistici
            // 
            this.tabStatistici.Location = new System.Drawing.Point(4, 22);
            this.tabStatistici.Name = "tabStatistici";
            this.tabStatistici.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistici.Size = new System.Drawing.Size(893, 366);
            this.tabStatistici.TabIndex = 0;
            this.tabStatistici.Text = "Statistici";
            this.tabStatistici.UseVisualStyleBackColor = true;
            // 
            // tabMorminte
            // 
            this.tabMorminte.Location = new System.Drawing.Point(4, 22);
            this.tabMorminte.Name = "tabMorminte";
            this.tabMorminte.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorminte.Size = new System.Drawing.Size(893, 366);
            this.tabMorminte.TabIndex = 1;
            this.tabMorminte.Text = "Morminte";
            this.tabMorminte.UseVisualStyleBackColor = true;
            // 
            // tabCetateni
            // 
            this.tabCetateni.Controls.Add(this.textBoxCnpCetatean);
            this.tabCetateni.Controls.Add(this.butonActualizareCetatean);
            this.tabCetateni.Controls.Add(this.label2);
            this.tabCetateni.Controls.Add(this.butonCautareCetatean);
            this.tabCetateni.Controls.Add(this.label1);
            this.tabCetateni.Controls.Add(this.butonAdaugareCetatean);
            this.tabCetateni.Controls.Add(this.gridViewCetateni);
            this.tabCetateni.Location = new System.Drawing.Point(4, 22);
            this.tabCetateni.Name = "tabCetateni";
            this.tabCetateni.Size = new System.Drawing.Size(893, 366);
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
            this.tabDecedati.Size = new System.Drawing.Size(893, 366);
            this.tabDecedati.TabIndex = 3;
            this.tabDecedati.Text = "Decedati";
            this.tabDecedati.UseVisualStyleBackColor = true;
            // 
            // tabCereri
            // 
            this.tabCereri.Location = new System.Drawing.Point(4, 22);
            this.tabCereri.Name = "tabCereri";
            this.tabCereri.Size = new System.Drawing.Size(893, 366);
            this.tabCereri.TabIndex = 4;
            this.tabCereri.Text = "Cereri";
            this.tabCereri.UseVisualStyleBackColor = true;
            // 
            // tabContracte
            // 
            this.tabContracte.Location = new System.Drawing.Point(4, 22);
            this.tabContracte.Name = "tabContracte";
            this.tabContracte.Size = new System.Drawing.Size(893, 366);
            this.tabContracte.TabIndex = 5;
            this.tabContracte.Text = "Contracte";
            this.tabContracte.UseVisualStyleBackColor = true;
            // 
            // tabInmormantari
            // 
            this.tabInmormantari.Controls.Add(this.programariView);
            this.tabInmormantari.Controls.Add(this.stergeButton);
            this.tabInmormantari.Controls.Add(this.actualizaButton);
            this.tabInmormantari.Controls.Add(this.cautaInIntervalButton);
            this.tabInmormantari.Controls.Add(this.endDatePicker);
            this.tabInmormantari.Controls.Add(this.startDatePicker);
            this.tabInmormantari.Controls.Add(this.cautaDupaDecedatButton);
            this.tabInmormantari.Controls.Add(this.cnpTextBox);
            this.tabInmormantari.Controls.Add(this.adaugaButton);
            this.tabInmormantari.Location = new System.Drawing.Point(4, 22);
            this.tabInmormantari.Name = "tabInmormantari";
            this.tabInmormantari.Size = new System.Drawing.Size(893, 366);
            this.tabInmormantari.TabIndex = 6;
            this.tabInmormantari.Text = "Programare Inmormantari";
            this.tabInmormantari.UseVisualStyleBackColor = true;
            // 
            // programariView
            // 
            this.programariView.AllowUserToAddRows = false;
            this.programariView.AllowUserToDeleteRows = false;
            this.programariView.AutoGenerateColumns = false;
            this.programariView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programariView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpDecedatDataGridViewTextBoxColumn,
            this.numeDecedatDataGridViewTextBoxColumn,
            this.prenumeDecedatDataGridViewTextBoxColumn,
            this.religieDataGridViewTextBoxColumn,
            this.cimitirDataGridViewTextBoxColumn,
            this.parcelaDataGridViewTextBoxColumn,
            this.numarMormantDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.programariView.DataSource = this.programareInmormantareDTOBindingSource;
            this.programariView.Location = new System.Drawing.Point(308, 3);
            this.programariView.Name = "programariView";
            this.programariView.ReadOnly = true;
            this.programariView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.programariView.Size = new System.Drawing.Size(578, 347);
            this.programariView.TabIndex = 8;
            // 
            // cnpDecedatDataGridViewTextBoxColumn
            // 
            this.cnpDecedatDataGridViewTextBoxColumn.DataPropertyName = "CnpDecedat";
            this.cnpDecedatDataGridViewTextBoxColumn.HeaderText = "Cnp";
            this.cnpDecedatDataGridViewTextBoxColumn.Name = "cnpDecedatDataGridViewTextBoxColumn";
            this.cnpDecedatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDecedatDataGridViewTextBoxColumn
            // 
            this.numeDecedatDataGridViewTextBoxColumn.DataPropertyName = "NumeDecedat";
            this.numeDecedatDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDecedatDataGridViewTextBoxColumn.Name = "numeDecedatDataGridViewTextBoxColumn";
            this.numeDecedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDecedatDataGridViewTextBoxColumn.Width = 55;
            // 
            // prenumeDecedatDataGridViewTextBoxColumn
            // 
            this.prenumeDecedatDataGridViewTextBoxColumn.DataPropertyName = "PrenumeDecedat";
            this.prenumeDecedatDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDecedatDataGridViewTextBoxColumn.Name = "prenumeDecedatDataGridViewTextBoxColumn";
            this.prenumeDecedatDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenumeDecedatDataGridViewTextBoxColumn.Width = 55;
            // 
            // religieDataGridViewTextBoxColumn
            // 
            this.religieDataGridViewTextBoxColumn.DataPropertyName = "Religie";
            this.religieDataGridViewTextBoxColumn.HeaderText = "Religie";
            this.religieDataGridViewTextBoxColumn.Name = "religieDataGridViewTextBoxColumn";
            this.religieDataGridViewTextBoxColumn.ReadOnly = true;
            this.religieDataGridViewTextBoxColumn.Width = 55;
            // 
            // cimitirDataGridViewTextBoxColumn
            // 
            this.cimitirDataGridViewTextBoxColumn.DataPropertyName = "Cimitir";
            this.cimitirDataGridViewTextBoxColumn.HeaderText = "Cimitir";
            this.cimitirDataGridViewTextBoxColumn.Name = "cimitirDataGridViewTextBoxColumn";
            this.cimitirDataGridViewTextBoxColumn.ReadOnly = true;
            this.cimitirDataGridViewTextBoxColumn.Width = 55;
            // 
            // parcelaDataGridViewTextBoxColumn
            // 
            this.parcelaDataGridViewTextBoxColumn.DataPropertyName = "Parcela";
            this.parcelaDataGridViewTextBoxColumn.HeaderText = "Parcela";
            this.parcelaDataGridViewTextBoxColumn.Name = "parcelaDataGridViewTextBoxColumn";
            this.parcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.parcelaDataGridViewTextBoxColumn.Width = 50;
            // 
            // numarMormantDataGridViewTextBoxColumn
            // 
            this.numarMormantDataGridViewTextBoxColumn.DataPropertyName = "NumarMormant";
            this.numarMormantDataGridViewTextBoxColumn.HeaderText = "Nr.Morm.";
            this.numarMormantDataGridViewTextBoxColumn.Name = "numarMormantDataGridViewTextBoxColumn";
            this.numarMormantDataGridViewTextBoxColumn.ReadOnly = true;
            this.numarMormantDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // programareInmormantareDTOBindingSource
            // 
            this.programareInmormantareDTOBindingSource.DataSource = typeof(GraveyardManagement.Model.ModelProgramareInmormantare.ProgramareInmormantareDTO);
            // 
            // stergeButton
            // 
            this.stergeButton.Location = new System.Drawing.Point(20, 297);
            this.stergeButton.Name = "stergeButton";
            this.stergeButton.Size = new System.Drawing.Size(200, 31);
            this.stergeButton.TabIndex = 7;
            this.stergeButton.Text = "Sterge programarea selectata";
            this.stergeButton.UseVisualStyleBackColor = true;
            this.stergeButton.Click += new System.EventHandler(this.stergeButton_Click);
            // 
            // actualizaButton
            // 
            this.actualizaButton.Location = new System.Drawing.Point(20, 245);
            this.actualizaButton.Name = "actualizaButton";
            this.actualizaButton.Size = new System.Drawing.Size(200, 31);
            this.actualizaButton.TabIndex = 6;
            this.actualizaButton.Text = "Actualizeaza programarea selectata";
            this.actualizaButton.UseVisualStyleBackColor = true;
            this.actualizaButton.Click += new System.EventHandler(this.actualizaButton_Click);
            // 
            // cautaInIntervalButton
            // 
            this.cautaInIntervalButton.Location = new System.Drawing.Point(172, 157);
            this.cautaInIntervalButton.Name = "cautaInIntervalButton";
            this.cautaInIntervalButton.Size = new System.Drawing.Size(130, 28);
            this.cautaInIntervalButton.TabIndex = 5;
            this.cautaInIntervalButton.Text = "Cauta in interval";
            this.cautaInIntervalButton.UseVisualStyleBackColor = true;
            this.cautaInIntervalButton.Click += new System.EventHandler(this.cautaInIntervalButton_Click);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(20, 178);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(134, 20);
            this.endDatePicker.TabIndex = 4;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(20, 142);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(134, 20);
            this.startDatePicker.TabIndex = 3;
            // 
            // cautaDupaDecedatButton
            // 
            this.cautaDupaDecedatButton.Location = new System.Drawing.Point(172, 95);
            this.cautaDupaDecedatButton.Name = "cautaDupaDecedatButton";
            this.cautaDupaDecedatButton.Size = new System.Drawing.Size(130, 28);
            this.cautaDupaDecedatButton.TabIndex = 2;
            this.cautaDupaDecedatButton.Text = "Cauta dupa decedat";
            this.cautaDupaDecedatButton.UseVisualStyleBackColor = true;
            this.cautaDupaDecedatButton.Click += new System.EventHandler(this.cautaDupaDecedatButton_Click);
            // 
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(20, 95);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(134, 20);
            this.cnpTextBox.TabIndex = 1;
            this.cnpTextBox.WatermarkText = "CNP Decedat";
            // 
            // adaugaButton
            // 
            this.adaugaButton.Location = new System.Drawing.Point(20, 20);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(98, 27);
            this.adaugaButton.TabIndex = 0;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // textBoxCnpCetatean
            // 
            this.textBoxCnpCetatean.Location = new System.Drawing.Point(4, 70);
            this.textBoxCnpCetatean.Name = "textBoxCnpCetatean";
            this.textBoxCnpCetatean.Size = new System.Drawing.Size(153, 20);
            this.textBoxCnpCetatean.TabIndex = 7;
            this.textBoxCnpCetatean.WatermarkText = "CNP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabCetateni.ResumeLayout(false);
            this.tabCetateni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCetateni)).EndInit();
            this.tabInmormantari.ResumeLayout(false);
            this.tabInmormantari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programariView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programareInmormantareDTOBindingSource)).EndInit();
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
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button cautaDupaDecedatButton;
        private WatermarkTextBox cnpTextBox;
        private System.Windows.Forms.Button cautaInIntervalButton;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Button stergeButton;
        private System.Windows.Forms.Button actualizaButton;
        private System.Windows.Forms.DataGridView programariView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDecedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDecedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDecedatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimitirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarMormantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource programareInmormantareDTOBindingSource;
        private WatermarkTextBox textBoxCnpCetatean;
    }
}