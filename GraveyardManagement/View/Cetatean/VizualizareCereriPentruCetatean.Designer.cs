namespace GraveyardManagement.View.Cetatean
{
    partial class VizualizareCereriPentruCetatean
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
            this.cereriGridView = new System.Windows.Forms.DataGridView();
            this.numarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliuCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numarInfocetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInregistrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerereDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cereriGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerereDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cereriGridView
            // 
            this.cereriGridView.AllowUserToAddRows = false;
            this.cereriGridView.AllowUserToDeleteRows = false;
            this.cereriGridView.AutoGenerateColumns = false;
            this.cereriGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cereriGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numarDataGridViewTextBoxColumn,
            this.cnpCetateanDataGridViewTextBoxColumn,
            this.numeCetateanDataGridViewTextBoxColumn,
            this.prenumeCetateanDataGridViewTextBoxColumn,
            this.domiciliuCetateanDataGridViewTextBoxColumn,
            this.numarInfocetDataGridViewTextBoxColumn,
            this.dataInregistrareDataGridViewTextBoxColumn,
            this.stadiuDataGridViewTextBoxColumn});
            this.cereriGridView.DataSource = this.cerereDtoBindingSource;
            this.cereriGridView.Location = new System.Drawing.Point(13, 13);
            this.cereriGridView.Name = "cereriGridView";
            this.cereriGridView.ReadOnly = true;
            this.cereriGridView.Size = new System.Drawing.Size(664, 270);
            this.cereriGridView.TabIndex = 0;
            // 
            // numarDataGridViewTextBoxColumn
            // 
            this.numarDataGridViewTextBoxColumn.DataPropertyName = "Numar";
            this.numarDataGridViewTextBoxColumn.HeaderText = "Numar";
            this.numarDataGridViewTextBoxColumn.Name = "numarDataGridViewTextBoxColumn";
            this.numarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpCetateanDataGridViewTextBoxColumn
            // 
            this.cnpCetateanDataGridViewTextBoxColumn.DataPropertyName = "CnpCetatean";
            this.cnpCetateanDataGridViewTextBoxColumn.HeaderText = "CnpCetatean";
            this.cnpCetateanDataGridViewTextBoxColumn.Name = "cnpCetateanDataGridViewTextBoxColumn";
            this.cnpCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeCetateanDataGridViewTextBoxColumn
            // 
            this.numeCetateanDataGridViewTextBoxColumn.DataPropertyName = "NumeCetatean";
            this.numeCetateanDataGridViewTextBoxColumn.HeaderText = "NumeCetatean";
            this.numeCetateanDataGridViewTextBoxColumn.Name = "numeCetateanDataGridViewTextBoxColumn";
            this.numeCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeCetateanDataGridViewTextBoxColumn
            // 
            this.prenumeCetateanDataGridViewTextBoxColumn.DataPropertyName = "PrenumeCetatean";
            this.prenumeCetateanDataGridViewTextBoxColumn.HeaderText = "PrenumeCetatean";
            this.prenumeCetateanDataGridViewTextBoxColumn.Name = "prenumeCetateanDataGridViewTextBoxColumn";
            this.prenumeCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domiciliuCetateanDataGridViewTextBoxColumn
            // 
            this.domiciliuCetateanDataGridViewTextBoxColumn.DataPropertyName = "DomiciliuCetatean";
            this.domiciliuCetateanDataGridViewTextBoxColumn.HeaderText = "DomiciliuCetatean";
            this.domiciliuCetateanDataGridViewTextBoxColumn.Name = "domiciliuCetateanDataGridViewTextBoxColumn";
            this.domiciliuCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numarInfocetDataGridViewTextBoxColumn
            // 
            this.numarInfocetDataGridViewTextBoxColumn.DataPropertyName = "NumarInfocet";
            this.numarInfocetDataGridViewTextBoxColumn.HeaderText = "NumarInfocet";
            this.numarInfocetDataGridViewTextBoxColumn.Name = "numarInfocetDataGridViewTextBoxColumn";
            this.numarInfocetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInregistrareDataGridViewTextBoxColumn
            // 
            this.dataInregistrareDataGridViewTextBoxColumn.DataPropertyName = "DataInregistrare";
            this.dataInregistrareDataGridViewTextBoxColumn.HeaderText = "DataInregistrare";
            this.dataInregistrareDataGridViewTextBoxColumn.Name = "dataInregistrareDataGridViewTextBoxColumn";
            this.dataInregistrareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stadiuDataGridViewTextBoxColumn
            // 
            this.stadiuDataGridViewTextBoxColumn.DataPropertyName = "Stadiu";
            this.stadiuDataGridViewTextBoxColumn.HeaderText = "Stadiu";
            this.stadiuDataGridViewTextBoxColumn.Name = "stadiuDataGridViewTextBoxColumn";
            this.stadiuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cerereDtoBindingSource
            // 
            this.cerereDtoBindingSource.DataSource = typeof(GraveyardManagement.Model.Cerere.CerereDto);
            // 
            // VizualizareCereriPentruCetatean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 296);
            this.Controls.Add(this.cereriGridView);
            this.Name = "VizualizareCereriPentruCetatean";
            this.Text = "VizualizareCereriPentruCetatean";
            ((System.ComponentModel.ISupportInitialize)(this.cereriGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerereDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cereriGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliuCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarInfocetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInregistrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cerereDtoBindingSource;
    }
}