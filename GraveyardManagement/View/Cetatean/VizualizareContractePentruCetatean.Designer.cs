namespace GraveyardManagement.View.Cetatean
{
    partial class VizualizareContractePentruCetatean
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
            this.contracteGridView = new System.Windows.Forms.DataGridView();
            this.contractDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domiciliuCetateanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEliberareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataExpirareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contracteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contracteGridView
            // 
            this.contracteGridView.AllowUserToAddRows = false;
            this.contracteGridView.AllowUserToDeleteRows = false;
            this.contracteGridView.AutoGenerateColumns = false;
            this.contracteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contracteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numarDataGridViewTextBoxColumn,
            this.cnpCetateanDataGridViewTextBoxColumn,
            this.prenumeCetateanDataGridViewTextBoxColumn,
            this.numeCetateanDataGridViewTextBoxColumn,
            this.domiciliuCetateanDataGridViewTextBoxColumn,
            this.dataEliberareDataGridViewTextBoxColumn,
            this.dataExpirareDataGridViewTextBoxColumn});
            this.contracteGridView.DataSource = this.contractDtoBindingSource;
            this.contracteGridView.Location = new System.Drawing.Point(13, 13);
            this.contracteGridView.Name = "contracteGridView";
            this.contracteGridView.ReadOnly = true;
            this.contracteGridView.Size = new System.Drawing.Size(664, 271);
            this.contracteGridView.TabIndex = 0;
            // 
            // contractDtoBindingSource
            // 
            this.contractDtoBindingSource.DataSource = typeof(GraveyardManagement.Model.Contract.ContractDto);
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
            // prenumeCetateanDataGridViewTextBoxColumn
            // 
            this.prenumeCetateanDataGridViewTextBoxColumn.DataPropertyName = "PrenumeCetatean";
            this.prenumeCetateanDataGridViewTextBoxColumn.HeaderText = "PrenumeCetatean";
            this.prenumeCetateanDataGridViewTextBoxColumn.Name = "prenumeCetateanDataGridViewTextBoxColumn";
            this.prenumeCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeCetateanDataGridViewTextBoxColumn
            // 
            this.numeCetateanDataGridViewTextBoxColumn.DataPropertyName = "NumeCetatean";
            this.numeCetateanDataGridViewTextBoxColumn.HeaderText = "NumeCetatean";
            this.numeCetateanDataGridViewTextBoxColumn.Name = "numeCetateanDataGridViewTextBoxColumn";
            this.numeCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domiciliuCetateanDataGridViewTextBoxColumn
            // 
            this.domiciliuCetateanDataGridViewTextBoxColumn.DataPropertyName = "DomiciliuCetatean";
            this.domiciliuCetateanDataGridViewTextBoxColumn.HeaderText = "DomiciliuCetatean";
            this.domiciliuCetateanDataGridViewTextBoxColumn.Name = "domiciliuCetateanDataGridViewTextBoxColumn";
            this.domiciliuCetateanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEliberareDataGridViewTextBoxColumn
            // 
            this.dataEliberareDataGridViewTextBoxColumn.DataPropertyName = "DataEliberare";
            this.dataEliberareDataGridViewTextBoxColumn.HeaderText = "DataEliberare";
            this.dataEliberareDataGridViewTextBoxColumn.Name = "dataEliberareDataGridViewTextBoxColumn";
            this.dataEliberareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataExpirareDataGridViewTextBoxColumn
            // 
            this.dataExpirareDataGridViewTextBoxColumn.DataPropertyName = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn.HeaderText = "DataExpirare";
            this.dataExpirareDataGridViewTextBoxColumn.Name = "dataExpirareDataGridViewTextBoxColumn";
            this.dataExpirareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // VizualizareContractePentruCetatean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 296);
            this.Controls.Add(this.contracteGridView);
            this.Name = "VizualizareContractePentruCetatean";
            this.Text = "VizualizareContractePentruCetatean";
            ((System.ComponentModel.ISupportInitialize)(this.contracteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDtoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contracteGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domiciliuCetateanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEliberareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataExpirareDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contractDtoBindingSource;
    }
}