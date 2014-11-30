using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraveyardManagement.Model.Utils;

namespace GraveyardManagement.View.Mormant
{
    public partial class AdaugaMormant : Form
    {
        public AdaugaMormant()
        {
            InitializeComponent();
            confirmButton.DialogResult = DialogResult.OK;
            cancelButton.DialogResult = DialogResult.Cancel;

            var cimitire = Global.GlobalVariables.Utils.IncarcaToateCimitirele();
            foreach (var it in cimitire)
            {
                cimitirCombo.Items.Add(it);
            }
            cimitirCombo.DisplayMember = "Name";
        }

        public CimitirDTO getCimitir()
        {
            if (this.cimitirCombo.SelectedItem != null)
            {
                return (CimitirDTO)this.cimitirCombo.SelectedItem;
            }
            return null;
        }

        public String getParcela()
        {
            return this.parcelaTextBox.Text;
        }
    }
}
