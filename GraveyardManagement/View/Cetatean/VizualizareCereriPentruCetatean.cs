using System.Windows.Forms;
using GraveyardManagement.Controller;

namespace GraveyardManagement.View.Cetatean
{
    public partial class VizualizareCereriPentruCetatean : Form
    {
        public VizualizareCereriPentruCetatean(string cnpCetatean)
        {
            InitializeComponent();

            var cetateanService = new CetateanService();

            cereriGridView.DataSource = cetateanService.CautaCereri(cnpCetatean);
        }
    }
}
