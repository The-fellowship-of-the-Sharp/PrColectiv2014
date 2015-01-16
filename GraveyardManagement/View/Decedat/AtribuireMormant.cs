using GraveyardManagement.Controller;
using GraveyardManagement.Model.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraveyardManagement.View.Decedat
{
    public partial class AtribuireMormant : Form
    {
        List<CimitirDTO> cimitire;
        private readonly DecedatService _decedatService;

        public AtribuireMormant(string decedat)
        {
            InitializeComponent();
            label1.Text = decedat;
            _decedatService = new DecedatService();

            this.cimitire = Global.GlobalVariables.Utils.IncarcaToateCimitirele();
            foreach (CimitirDTO it in cimitire)
            {
                cimitirCombo.Items.Add(it);
            }
            cimitirCombo.ValueMember = "Id";
            cimitirCombo.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CimitirDTO cimitir = (CimitirDTO)this.cimitirCombo.SelectedItem;

                _decedatService.AtribuieMormant(label1.Text.Substring(0, 13), cimitir.Id, watermarkTextBox1.Text, txt_Suprafata.Text.Trim(), Int32.Parse(watermarkTextBox2.Text));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
