using System;
using System.Linq;
using System.Windows.Forms;
using GraveyardManagement.Global;

namespace GraveyardManagement.View.ProgramareInmormantari
{
    public partial class ActualizeazaProgramareForm : Form
    {
        public ActualizeazaProgramareForm()
        {
            InitializeComponent();

            confirmaButton.DialogResult = DialogResult.OK;
            renuntaButton.DialogResult = DialogResult.Cancel;
        }

        public void SetValues(string cimitir, string parcela, int? numarMormant, DateTime? data, string religie)
        {
            var entities = GlobalVariables.Entities;
            foreach (var c in entities.Cimitir.ToArray())
            {
                cimitirComboBox.Items.Add(c.nume);
            }
            cimitirComboBox.Text = cimitir;
            parcelaTextBox.Text = parcela;
            numarMormantTextBox.Text = numarMormant.ToString();
            datePicker.Value = data.GetValueOrDefault();
            foreach (var r in entities.Religie.ToArray())
            {
                religieComboBox.Items.Add(r.nume);
            }
            religieComboBox.Text = religie;
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
    }
}
