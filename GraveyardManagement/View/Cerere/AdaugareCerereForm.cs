using System;
using System.Windows.Forms;
using GraveyardManagement.Controller;

namespace GraveyardManagement.View.Cerere
{
    public partial class AdaugareCerereForm : Form
    {
        private readonly CerereService _cerereService;

        public AdaugareCerereForm()
        {
            InitializeComponent();

            _cerereService = new CerereService();
        }

        private void butonRenuntare_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butonConfirmare_Click(object sender, EventArgs e)
        {
            int nrInfocet;
            try
            {
                nrInfocet = Convert.ToInt32(nrInfocetTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numarul Infocet introdus este invalid!");
                return;
            }

            try
            {
                _cerereService.AdaugaCerere(cnpCetateanTextBox.Text, nrInfocet, dataInregistrarePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Close();
        }
    }
}
