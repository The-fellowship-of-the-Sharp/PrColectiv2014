using System.Windows.Forms;
using GraveyardManagement.CustomControls;

namespace GraveyardManagement.View
{
    public partial class MainForm : Form
    {
        private WatermarkTextBox _textBoxCnp;

        public MainForm()
        {
            InitializeComponent();

            InitializeUiCetateni();
        }

        private void InitializeUiCetateni()
        {
            _textBoxCnp = new WatermarkTextBox
            {
                Cursor = Cursors.IBeam,
                Location = new System.Drawing.Point(4, 69),
                Name = "textBoxCnp",
                Size = new System.Drawing.Size(153, 20),
                TabIndex = 3,
                WatermarkText = "CNP"
            };

            tabCetateni.Controls.Add(_textBoxCnp);
        }
    }
}
