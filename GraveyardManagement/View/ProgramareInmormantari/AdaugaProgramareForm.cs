using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraveyardManagement.Global;

namespace GraveyardManagement.View.ProgramareInmormantari
{
    public partial class AdaugaProgramareForm : Form
    {
        public AdaugaProgramareForm()
        {
            InitializeComponent();

            renuntaButton.DialogResult = DialogResult.Cancel;
            confirmaButton.DialogResult = DialogResult.OK;

            var entities = GlobalVariables.Entities;
            foreach (var c in entities.Cimitir.ToArray())
            {
                cimitirComboBox.Items.Add(c.nume);
            }
            foreach (var r in entities.Religie.ToArray())
            {
                religieComboBox.Items.Add(r.nume);
            }
        }

        public string GetCimitir()
        {
            return cimitirComboBox.Text;
        }

        public string GetParcela()
        {
            return parcelaTextBox.Text;
        }

        public int GetNumarMormant()
        {
            return Convert.ToInt32(numarMormantTextBox.Text);
        }

        public DateTime GetDateTime()
        {
            return datePicker.Value;
        }

        public string GetReligie()
        {
            return religieComboBox.Text;
        }

        public string GetCNP()
        {
            return cnpTextBox.Text;
        }
    }
}
