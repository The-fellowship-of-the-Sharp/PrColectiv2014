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

namespace GraveyardManagement.View.Contract
{
    public partial class AdaugareContractForm : Form
    {
        private ContractService _contractService;

        public AdaugareContractForm()
        {
            InitializeComponent();
            _contractService = new ContractService();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cupropietarbtn_Click(object sender, EventArgs e)
        {
            int nrContract=0, nrChitanta=0, idLocAlocat=0;
            string CnpDecedat, CnpProp1, CnpProp2;

            try
            {
                CnpDecedat = CNPDecedatContractTextBox.Text.ToString();
                if (CnpDecedat.Length != 13)
                {
                    throw new Exception();
                }
               idLocAlocat = _contractService.findLocAlocat(CnpDecedat);
            }
            catch (Exception error)
            {
                MessageBox.Show("CNP-ul decedatului este invalid!" + error.Message);
            }
            try
            {
                nrContract = Convert.ToInt32(nrContactTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numar contract invalid");
            }

            try
            {
                nrChitanta = Convert.ToInt32(nrChitantaTextBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numar chitanta este invalit.");
            }
            try
            {
                CnpProp1 = CNPPropietar1TextBox.Text.ToString();
                if (CnpProp1.Length != 13)
                {
                    throw new Exception();
                }
                CnpProp2 = CNPPropietar2TextBox.Text.ToString();
                if (CnpProp2 != null)
                {
                    if (CnpProp2.Length != 13)
                    {
                        throw new Exception();
                    }
                }
                _contractService.AddPropContract(nrContract, ContractEliberareDateTimePicker.Value, ContractExpirareDateTimePicker.Value, idLocAlocat, CnpProp1, CnpProp2, nrChitanta, ChitantaDateTimePicker.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("CNP proprietarului este invalid");
            }

        }

        private void faraProprietarBtn_Click(object sender, EventArgs e)
        {
            int nrContract = 0, solSocial, adevInhumare, idLocAlocat = 0;
            string CnpDecedat;

            try
            {
                CnpDecedat = CNPDecedatContractTextBox.Text.ToString();
                if (CnpDecedat.Length != 13)
                {
                    throw new Exception();
                }
                idLocAlocat = _contractService.findLocAlocat(CnpDecedat);
            }
            catch (Exception error)
            {
                MessageBox.Show("CNP-ul decedatului este invalid!" + error.Message);
            }
            try
            {
                nrContract = Convert.ToInt32(nrContactTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numar contract invalid");
            }

            try
            {
                solSocial = Convert.ToInt32(solicitareAsistentaSocialaTextBox2.Text);
                adevInhumare = Convert.ToInt32(adeverintaInhumareTextBox1.Text);
                _contractService.AddFaraProcContract(nrContract, ContractEliberareDateTimePicker.Value, ContractExpirareDateTimePicker.Value, idLocAlocat, solSocial, adevInhumare);
            }
            catch (Exception)
            {
                MessageBox.Show("Serviciu Social incorect sau numar adeverinta inhumare incorect.");
            }

        }


    }
}
