using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using GraveyardManagement.Controller;
using GraveyardManagement.Utils.Exceptions;

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
                _decedatService.AdaugaDecedat(cnpTextBox.Text.Trim(), numeTextBox.Text.Trim(),
                    prenumeTextBox.Text.Trim());

                Close();
            }
            catch (ConflictCetateanDecedatException ex)
            {
                var dialogResult = MessageBox.Show(
                    "Exista deja un cetatean cu CNP-ul introdus! Doriti sa il mutati in registrul persoanelor decedate?", "CNP deja existent", MessageBoxButtons.OKCancel);
                if (dialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    _decedatService.TransformaCetateanInDecedat(cnpTextBox.Text.Trim());
                    Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    MessageBox.Show(ex.InnerException.ToString());
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
