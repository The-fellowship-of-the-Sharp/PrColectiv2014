using System;
using System.Windows.Forms;
using GraveyardManagement.Controller;
using GraveyardManagement.Model.Cerere;

namespace GraveyardManagement.View.Cerere
{
    public partial class ActualizareCerereForm : Form
    {
        private readonly CerereService _cerereService;

        private readonly int _numarCerere;

        public ActualizareCerereForm(int numar)
        {
            InitializeComponent();

            _numarCerere = numar;

            _cerereService = new CerereService();

            InitializeGui();
        }

        private void InitializeGui()
        {
            CerereDto cerere;
            try
            {
                cerere = _cerereService.CautaCerere(_numarCerere);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                return;
            }

            cnpCetateanLabel.Text += cerere.CnpCetatean;
            nrInfocetLabel.Text += cerere.NumarInfocet;
            dataInregistrareLabel.Text += cerere.DataInregistrare.ToShortDateString();

            stadiuComboBox.DataSource = _cerereService.ObtineToateStadiile();

            stadiuComboBox.SelectedItem = cerere.Stadiu;
        }

        private void butonRenuntare_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void butonConfirmare_Click(object sender, System.EventArgs e)
        {
            try
            {
                _cerereService.ActualizeazaCerere(_numarCerere, stadiuComboBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }
    }
}
