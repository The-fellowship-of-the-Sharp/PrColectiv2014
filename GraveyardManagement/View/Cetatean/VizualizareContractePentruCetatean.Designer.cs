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
            this.contracteGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.contracteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contracteGridView
            // 
            this.contracteGridView.AllowUserToAddRows = false;
            this.contracteGridView.AllowUserToDeleteRows = false;
            this.contracteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contracteGridView.Location = new System.Drawing.Point(13, 13);
            this.contracteGridView.Name = "contracteGridView";
            this.contracteGridView.ReadOnly = true;
            this.contracteGridView.Size = new System.Drawing.Size(664, 271);
            this.contracteGridView.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView contracteGridView;
    }
}