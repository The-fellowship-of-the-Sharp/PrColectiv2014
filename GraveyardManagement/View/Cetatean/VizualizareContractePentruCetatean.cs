using System.Windows.Forms;
using GraveyardManagement.Controller;

namespace GraveyardManagement.View.Cetatean
{
    public partial class VizualizareContractePentruCetatean : Form
    {
        public VizualizareContractePentruCetatean(string cnpCetatean)
        {
            InitializeComponent();

            var cetateanService = new CetateanService();

            contracteGridView.DataSource = cetateanService.CautaContracte(cnpCetatean);
        }
    }
}
