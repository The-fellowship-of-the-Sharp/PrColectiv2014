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

namespace GraveyardManagement.View.Decedat
{
    public partial class AdaugareDecedat : Form
    {
        private readonly DecedatService  _decedatService;

        public AdaugareDecedat()
        {
            InitializeComponent();

            _decedatService = new DecedatService();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _decedatService.AdaugaDecedat(cnpTextBox.Text.Trim(), numeTextBox.Text.Trim(), prenumeTextBox.Text.Trim());

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
