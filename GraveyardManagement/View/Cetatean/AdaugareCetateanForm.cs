using System;
using System.Windows.Forms;
using GraveyardManagement.Controller;

namespace GraveyardManagement.View.Cetatean
{
    public partial class AdaugareCetateanForm : Form
    {
        private readonly CetateanService _cetateanService;

        public AdaugareCetateanForm()
        {
            InitializeComponent();

            _cetateanService = new CetateanService();

            InitializeUi();
        }

        private void InitializeUi()
        {
            localitateComboBox.DataSource = _cetateanService.ObtineLocalitatile();
        }

        private void butonConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                _cetateanService.AdaugaCetatean(cnpTextBox.Text.Trim(), numeTextBox.Text.Trim(), prenumeTextBox.Text.Trim(),
                    localitateComboBox.SelectedItem.ToString().Trim(), stradaTextBox.Text.TrimStart().TrimEnd(),
                    numarTextBox.Text.Trim(), detaliiTextBox.Text.TrimStart().TrimEnd());

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butonRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
