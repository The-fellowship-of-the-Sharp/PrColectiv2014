using System;
using System.Windows.Forms;
using GraveyardManagement.Controller;

namespace GraveyardManagement.View.Cetatean
{
    public partial class ActualizareCetateanForm : Form
    {
        private readonly CetateanService _cetateanService;

        public ActualizareCetateanForm(string cnp)
        {
            InitializeComponent();

            _cetateanService = new CetateanService();

            InitializareUi(cnp);
        }

        private void InitializareUi(string cnp)
        {
            var cetatean = _cetateanService.CautaCetatean(cnp);

            var localitati = _cetateanService.ObtineLocalitatile();

            cnpLabel.Text = cnp;

            numeTextBox.Text = cetatean.Nume;

            prenumeTextBox.Text = cetatean.Prenume;

            localitateComboBox.DataSource = localitati;

            stradaTextBox.Text = cetatean.Strada;

            numarTextBox.Text = cetatean.Numar;

            detaliiTextBox.Text = cetatean.AlteInformatii;
        }

        private void butonRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butonConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                _cetateanService.ActualizeazaCetatean(cnpLabel.Text, numeTextBox.Text.Trim(), prenumeTextBox.Text.Trim(),
                    localitateComboBox.SelectedItem.ToString().Trim(), stradaTextBox.Text.TrimStart().TrimEnd(),
                    numarTextBox.Text.Trim(), detaliiTextBox.Text.TrimStart().TrimEnd());

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
