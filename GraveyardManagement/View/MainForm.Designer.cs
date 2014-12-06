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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStatistici = new System.Windows.Forms.TabPage();
            this.tabMorminte = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cautaLoc = new System.Windows.Forms.Button();
            this.filtruCimitir = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.adaugaMorminte = new System.Windows.Forms.Button();
            this.morminteView = new System.Windows.Forms.DataGridView();
            this.cimitirMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suprafataMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeMormant = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.stergeButton = new System.Windows.Forms.Button();
            this.actualizaButton = new System.Windows.Forms.Button();
            this.cautaInIntervalButton = new System.Windows.Forms.Button();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.cautaDupaDecedatButton = new System.Windows.Forms.Button();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.cnpCetateanTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.cetateanDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filtruParcela = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.filtruNumar = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.filtruCNP = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.cnpDecedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDecedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDecedatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimitirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarMormantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programareInmormantareDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cnpTextBox = new GraveyardManagement.CustomControls.WatermarkTextBox();
            this.cnpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alteInformatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabMorminte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morminteView)).BeginInit();
            this.tabCetateni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCetateni)).BeginInit();
            this.tabInmormantari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programariView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetateanDtoBindingSource)).BeginInit();
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
            this.tabMorminte.Controls.Add(this.button2);
            this.tabMorminte.Controls.Add(this.cautaLoc);
            this.tabMorminte.Controls.Add(this.filtruParcela);
            this.tabMorminte.Controls.Add(this.filtruNumar);
            this.tabMorminte.Controls.Add(this.filtruCimitir);
            this.tabMorminte.Controls.Add(this.button1);
            this.tabMorminte.Controls.Add(this.filtruCNP);
            this.tabMorminte.Controls.Add(this.adaugaMorminte);
            this.tabMorminte.Controls.Add(this.morminteView);
            this.tabMorminte.Location = new System.Drawing.Point(4, 22);
            this.tabMorminte.Name = "tabMorminte";
            this.tabMorminte.Padding = new System.Windows.Forms.Padding(3);
            this.tabMorminte.Size = new System.Drawing.Size(893, 366);
            this.tabMorminte.TabIndex = 1;
            this.tabMorminte.Text = "Morminte";
            this.tabMorminte.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Elibereaza mormantul selectat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cautaLoc
            // 
            this.cautaLoc.Location = new System.Drawing.Point(148, 130);
            this.cautaLoc.Name = "cautaLoc";
            this.cautaLoc.Size = new System.Drawing.Size(125, 23);
            this.cautaLoc.TabIndex = 7;
            this.cautaLoc.Text = "Cauta dupa loc";
            this.cautaLoc.UseVisualStyleBackColor = true;
            this.cautaLoc.Click += new System.EventHandler(this.cautaLoc_Click);
            // 
            // filtruCimitir
            // 
            this.filtruCimitir.FormattingEnabled = true;
            this.filtruCimitir.Location = new System.Drawing.Point(7, 105);
            this.filtruCimitir.Name = "filtruCimitir";
            this.filtruCimitir.Size = new System.Drawing.Size(120, 21);
            this.filtruCimitir.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cauta dupa decedat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adaugaMorminte
            // 
            this.adaugaMorminte.Location = new System.Drawing.Point(6, 6);
            this.adaugaMorminte.Name = "adaugaMorminte";
            this.adaugaMorminte.Size = new System.Drawing.Size(75, 23);
            this.adaugaMorminte.TabIndex = 1;
            this.adaugaMorminte.Text = "Adauga";
            this.adaugaMorminte.UseVisualStyleBackColor = true;
            this.adaugaMorminte.Click += new System.EventHandler(this.adaugaMorminte_Click);
            // 
            // morminteView
            // 
            this.morminteView.AllowUserToAddRows = false;
            this.morminteView.AllowUserToDeleteRows = false;
            this.morminteView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.morminteView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cimitirMormant,
            this.parcelaMormant,
            this.numarMormant,
            this.dataExpirareMormant,
            this.suprafataMormant,
            this.cnpMormant,
            this.numeMormant,
            this.prenumeMormant,
            this.id});
            this.morminteView.Location = new System.Drawing.Point(306, 6);
            this.morminteView.MultiSelect = false;
            this.morminteView.Name = "morminteView";
            this.morminteView.ReadOnly = true;
            this.morminteView.Size = new System.Drawing.Size(580, 354);
            this.morminteView.TabIndex = 0;
            // 
            // cimitirMormant
            // 
            this.cimitirMormant.HeaderText = "Cimitir";
            this.cimitirMormant.Name = "cimitirMormant";
            this.cimitirMormant.ReadOnly = true;
            this.cimitirMormant.Width = 60;
            // 
            // parcelaMormant
            // 
            this.parcelaMormant.HeaderText = "Parcela";
            this.parcelaMormant.Name = "parcelaMormant";
            this.parcelaMormant.ReadOnly = true;
            this.parcelaMormant.Width = 50;
            // 
            // numarMormant
            // 
            this.numarMormant.HeaderText = "Nr mormant";
            this.numarMormant.Name = "numarMormant";
            this.numarMormant.ReadOnly = true;
            this.numarMormant.Width = 50;
            // 
            // dataExpirareMormant
            // 
            this.dataExpirareMormant.HeaderText = "Data Expirare";
            this.dataExpirareMormant.Name = "dataExpirareMormant";
            this.dataExpirareMormant.ReadOnly = true;
            this.dataExpirareMormant.Width = 70;
            // 
            // suprafataMormant
            // 
            this.suprafataMormant.HeaderText = "Suprafata";
            this.suprafataMormant.Name = "suprafataMormant";
            this.suprafataMormant.ReadOnly = true;
            this.suprafataMormant.Width = 60;
            // 
            // cnpMormant
            // 
            this.cnpMormant.HeaderText = "CNP Decedat";
            this.cnpMormant.Name = "cnpMormant";
            this.cnpMormant.ReadOnly = true;
            // 
            // numeMormant
            // 
            this.numeMormant.HeaderText = "Nume";
            this.numeMormant.Name = "numeMormant";
            this.numeMormant.ReadOnly = true;
            this.numeMormant.Width = 75;
            // 
            // prenumeMormant
            // 
            this.prenumeMormant.HeaderText = "Prenume";
            this.prenumeMormant.Name = "prenumeMormant";
            this.prenumeMormant.ReadOnly = true;
            this.prenumeMormant.Width = 75;
            // 
            // tabCetateni
            // 
            this.tabCetateni.Controls.Add(this.cnpCetateanTextBox);
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
            this.butonActualizareCetatean.Click += new System.EventHandler(this.butonActualizareCetatean_Click);
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
            this.butonCautareCetatean.Click += new System.EventHandler(this.butonCautareCetatean_Click);
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
            this.butonAdaugareCetatean.Click += new System.EventHandler(this.butonAdaugareCetatean_Click);
            // 
            // gridViewCetateni
            // 
            this.gridViewCetateni.AllowUserToAddRows = false;
            this.gridViewCetateni.AllowUserToDeleteRows = false;
            this.gridViewCetateni.AutoGenerateColumns = false;
            this.gridViewCetateni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCetateni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnpDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.localitateDataGridViewTextBoxColumn,
            this.stradaDataGridViewTextBoxColumn,
            this.numarDataGridViewTextBoxColumn,
            this.alteInformatiiDataGridViewTextBoxColumn});
            this.gridViewCetateni.DataSource = this.cetateanDtoBindingSource;
            this.gridViewCetateni.Location = new System.Drawing.Point(317, 15);
            this.gridViewCetateni.Name = "gridViewCetateni";
            this.gridViewCetateni.ReadOnly = true;
            this.gridViewCetateni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewCetateni.Size = new System.Drawing.Size(569, 289);
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
            // filtruParcela
            // 
            this.filtruParcela.Location = new System.Drawing.Point(7, 132);
            this.filtruParcela.Name = "filtruParcela";
            this.filtruParcela.Size = new System.Drawing.Size(120, 20);
            this.filtruParcela.TabIndex = 6;
            this.filtruParcela.WatermarkText = "Parcela";
            // 
            // filtruNumar
            // 
            this.filtruNumar.Location = new System.Drawing.Point(7, 158);
            this.filtruNumar.Name = "filtruNumar";
            this.filtruNumar.Size = new System.Drawing.Size(120, 20);
            this.filtruNumar.TabIndex = 5;
            this.filtruNumar.WatermarkText = "Numar";
            // 
            // filtruCNP
            // 
            this.filtruCNP.Location = new System.Drawing.Point(7, 51);
            this.filtruCNP.Name = "filtruCNP";
            this.filtruCNP.Size = new System.Drawing.Size(120, 20);
            this.filtruCNP.TabIndex = 2;
            this.filtruCNP.WatermarkText = "CNP";
            //
            // cnpCetateanTextBox
            //
            this.cnpCetateanTextBox.Location = new System.Drawing.Point(4, 70);
            this.cnpCetateanTextBox.Name = "cnpCetateanTextBox";
            this.cnpCetateanTextBox.Size = new System.Drawing.Size(153, 20);
            this.cnpCetateanTextBox.TabIndex = 7;
            this.cnpCetateanTextBox.WatermarkText = "CNP";
            // 
            // cetateanDtoBindingSource
            // 
            this.cetateanDtoBindingSource.DataSource = typeof(GraveyardManagement.Model.ModelCetatean.CetateanDto);
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
            // cnpTextBox
            // 
            this.cnpTextBox.Location = new System.Drawing.Point(20, 95);
            this.cnpTextBox.Name = "cnpTextBox";
            this.cnpTextBox.Size = new System.Drawing.Size(134, 20);
            this.cnpTextBox.TabIndex = 1;
            this.cnpTextBox.WatermarkText = "CNP Decedat";
            // 
            // cnpDataGridViewTextBoxColumn
            // 
            this.cnpDataGridViewTextBoxColumn.DataPropertyName = "Cnp";
            this.cnpDataGridViewTextBoxColumn.HeaderText = "Cnp";
            this.cnpDataGridViewTextBoxColumn.Name = "cnpDataGridViewTextBoxColumn";
            this.cnpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localitateDataGridViewTextBoxColumn
            // 
            this.localitateDataGridViewTextBoxColumn.DataPropertyName = "Localitate";
            this.localitateDataGridViewTextBoxColumn.HeaderText = "Localitate";
            this.localitateDataGridViewTextBoxColumn.Name = "localitateDataGridViewTextBoxColumn";
            this.localitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stradaDataGridViewTextBoxColumn
            // 
            this.stradaDataGridViewTextBoxColumn.DataPropertyName = "Strada";
            this.stradaDataGridViewTextBoxColumn.HeaderText = "Strada";
            this.stradaDataGridViewTextBoxColumn.Name = "stradaDataGridViewTextBoxColumn";
            this.stradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarDataGridViewTextBoxColumn
            // 
            this.numarDataGridViewTextBoxColumn.DataPropertyName = "Numar";
            this.numarDataGridViewTextBoxColumn.HeaderText = "Numar";
            this.numarDataGridViewTextBoxColumn.Name = "numarDataGridViewTextBoxColumn";
            this.numarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alteInformatiiDataGridViewTextBoxColumn
            // 
            this.alteInformatiiDataGridViewTextBoxColumn.DataPropertyName = "AlteInformatii";
            this.alteInformatiiDataGridViewTextBoxColumn.HeaderText = "AlteInformatii";
            this.alteInformatiiDataGridViewTextBoxColumn.Name = "alteInformatiiDataGridViewTextBoxColumn";
            this.alteInformatiiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
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
            this.tabMorminte.ResumeLayout(false);
            this.tabMorminte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morminteView)).EndInit();
            this.tabCetateni.ResumeLayout(false);
            this.tabCetateni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCetateni)).EndInit();
            this.tabInmormantari.ResumeLayout(false);
            this.tabInmormantari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programariView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cetateanDtoBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private WatermarkTextBox filtruCNP;
        private System.Windows.Forms.Button adaugaMorminte;
        private System.Windows.Forms.DataGridView morminteView;
        private System.Windows.Forms.ComboBox filtruCimitir;
        private System.Windows.Forms.Button cautaLoc;
        private WatermarkTextBox filtruParcela;
        private WatermarkTextBox filtruNumar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimitirMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn suprafataMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeMormant;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private WatermarkTextBox cnpCetateanTextBox;
        private System.Windows.Forms.BindingSource cetateanDtoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alteInformatiiDataGridViewTextBoxColumn;
    }
}