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
            cupropietarbtn.Enabled = false;
            faraProprietarBtn.Enabled = false;
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
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }
            try
            {
                nrContract = Convert.ToInt32(nrContactTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numar contract invalid");
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }

            try
            {
                nrChitanta = Convert.ToInt32(nrChitantaTextBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numar chitanta este invalit.");
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }
            try
            {
                CnpProp1 = CNPPropietar1TextBox.Text.ToString();
                if (CnpProp1.Length != 13)
                {
                    throw new Exception("Cnp primului proprietar e invalid");
                }
                CnpProp2 = CNPPropietar2TextBox.Text.ToString();
                if (CnpProp2.Length > 0)
                {
                    Console.WriteLine("CnpProp2:" + CnpProp2 +"uhmm?");
                    if (CnpProp2.Length != 13)
                    {
                        throw new Exception("Cnp proprietar 2 e invalid");
                    }
                }
                _contractService.AddPropContract(nrContract, ContractEliberareDateTimePicker.Value, ContractExpirareDateTimePicker.Value, idLocAlocat, CnpProp1, CnpProp2, nrChitanta, ChitantaDateTimePicker.Value);
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show( error.Message.ToString());
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }
        }

        private void faraProprietarBtn_Click(object sender, EventArgs e)
        {
            cupropietarbtn.Enabled = false;
            faraProprietarBtn.Enabled = false;
            int nrContract = 0, solSocial, adevInhumare, idLocAlocat = 0;
            string CnpDecedat;

            try
            {
                CnpDecedat = CNPDecedatContractTextBox.Text.ToString();
                if (CnpDecedat.Length != 13)
                {
                    throw new Exception("");
                }
                idLocAlocat = _contractService.findLocAlocat(CnpDecedat);
            }
            catch (Exception error)
            {
                MessageBox.Show("CNP-ul decedatului este invalid!" + error.Message);
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }
            try
            {
                nrContract = Convert.ToInt32(nrContactTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numar contract invalid");
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }

            try
            {
                solSocial = Convert.ToInt32(solicitareAsistentaSocialaTextBox2.Text);
                adevInhumare = Convert.ToInt32(adeverintaInhumareTextBox1.Text);
                _contractService.AddFaraProcContract(nrContract, ContractEliberareDateTimePicker.Value, ContractExpirareDateTimePicker.Value, idLocAlocat, solSocial, adevInhumare);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Serviciu Social incorect sau numar adeverinta inhumare incorect.");
                cupropietarbtn.Enabled = true;
                faraProprietarBtn.Enabled = true;
            }

        }


    }
}
