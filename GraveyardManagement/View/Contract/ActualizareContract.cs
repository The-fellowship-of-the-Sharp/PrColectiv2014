using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraveyardManagement.Controller;
using GraveyardManagement.Model.Contract;

namespace GraveyardManagement.View.Contract
{
    public partial class ActualizareContract : Form
    {
        private int  _numarContract;
        private ContractService _contactService;
        public ActualizareContract(int numar)
        {
            InitializeComponent();
            _numarContract = numar;
            _contactService = new ContractService();
            InitializeGui();
        }

        private void InitializeGui()
        {
            ContractDto contract;
            try
            {
                contract = _contactService.CautaContract(_numarContract);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                return;
            }

            Prenumelabel.Text += contract.PrenumeCetatean;
            Numelabel.Text += contract.NumeCetatean;
            DateEmitlabel.Text += contract.DataEliberare.ToShortDateString();

        }

        private void UpdateContractbutton_Click(object sender, EventArgs e)
        {
            int nrChitanta;
            try
            {
                nrChitanta = Convert.ToInt32(ChitantaTextBox.Text);
                _contactService.ActualizeazaContract(_numarContract, nrChitanta, CexpiraredateTimePicker.Value, ChitantadateTimePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }


    }
}
