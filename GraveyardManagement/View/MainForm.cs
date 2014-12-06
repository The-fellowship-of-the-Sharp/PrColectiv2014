using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GraveyardManagement.Controller;
using GraveyardManagement.Model.ModelCetatean;
using GraveyardManagement.Model.ModelProgramareInmormantare;
using GraveyardManagement.View.Cetatean;
using GraveyardManagement.View.ProgramareInmormantari;

namespace GraveyardManagement.View
{
    public partial class MainForm : Form
    {
        private ProgramareInmormantareService _programareInmormantare;
        private CetateanService _cetateanService;

        public MainForm()
        {
            InitializeComponent();

            InitializeUiProgramari();

            InitializeCetateni();
        }

        #region Programare Inmormantare
        private void InitializeUiProgramari()
        {
            _programareInmormantare = new ProgramareInmormantareService();
            tabInmormantari.Paint += (sender, args) =>
            {
                var g = args.Graphics;
                var xStart = adaugaButton.Location.X;
                var xEnd = cautaDupaDecedatButton.Location.X + cautaDupaDecedatButton.Size.Width;
                var yFirstLine = (cnpTextBox.Location.Y + adaugaButton.Location.Y + adaugaButton.Size.Height)/2;
                var ySecondLine = (actualizaButton.Location.Y + endDatePicker.Location.Y + endDatePicker.Size.Height)/2;
                g.DrawLine(Pens.Black, new Point(xStart, yFirstLine), new Point(xEnd, yFirstLine));
                g.DrawLine(Pens.Black, new Point(xStart, ySecondLine), new Point(xEnd, ySecondLine));
            };
        }

        private void cautaDupaDecedatButton_Click(object sender, EventArgs e)
        {
            var cnp = cnpTextBox.Text;
            var programare = _programareInmormantare.CautaProgramareInmormantareDupaCNP(cnp);
            programariView.DataSource = new[] {programare};
        }

        private void cautaInIntervalButton_Click(object sender, EventArgs e)
        {
            programariView.DataSource = _programareInmormantare.CautaProgramariInInterval(startDatePicker.Value,
                endDatePicker.Value);
        }

        private void stergeButton_Click(object sender, EventArgs e)
        {
            var selected = programariView.SelectedRows.Cast<DataGridViewRow>();
            var programari = selected
                .Select(row => row.DataBoundItem)
                .Cast<ProgramareInmormantareDTO>();
            foreach (var programare in programari)
            {
                _programareInmormantare.StergeProgramareInmormantare(programare.Id);
            }
            programariView.DataSource = null;
        }

        private void actualizaButton_Click(object sender, EventArgs e)
        {
            var selectedItems = programariView.SelectedRows.Cast<DataGridViewRow>();
            if (selectedItems.Count() != 1) return;
            var selected = selectedItems
                .Select(row => row.DataBoundItem)
                .Cast<ProgramareInmormantareDTO>()
                .First();
            var actualizeazaForm = new ActualizeazaProgramareForm();
            actualizeazaForm.SetValues(selected.Cimitir, selected.Parcela, selected.NumarMormant, selected.Data, selected.Religie);
            var result = actualizeazaForm.ShowDialog();
            if (result == DialogResult.Cancel) return;
            _programareInmormantare.ActualizeazaProgramareInmormantare(selected.Id, actualizeazaForm.GetCimitir(), actualizeazaForm.GetParcela(), actualizeazaForm.GetNumarMormant(), actualizeazaForm.GetDateTime(), actualizeazaForm.GetReligie());
            programariView.DataSource = null;
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            var adaugaForm = new AdaugaProgramareForm();
            var result = adaugaForm.ShowDialog();
            if (result == DialogResult.Cancel) return;
            var religie = adaugaForm.GetReligie();
            var cnp = adaugaForm.GetCNP();
            var cimitir = adaugaForm.GetCimitir();
            var data = adaugaForm.GetDateTime();
            var parcela = adaugaForm.GetParcela();
            var nrMormant = adaugaForm.GetNumarMormant();
            if (religie.Trim().Equals("") || cnp.Trim().Equals("") || cimitir.Trim().Equals("") ||
                parcela.Trim().Equals("")) return;
            _programareInmormantare.AdaugaProgramareInmormantare(cnp, cimitir, parcela, nrMormant, data, religie);
            programariView.DataSource = null;
        }
        #endregion

        #region Cetateni

        private void InitializeCetateni()
        {
            _cetateanService = new CetateanService();
        }

        private void butonAdaugareCetatean_Click(object sender, EventArgs e)
        {
            var form = new AdaugareCetateanForm();
            form.ShowDialog();
        }

        private void butonCautareCetatean_Click(object sender, EventArgs e)
        {
            CetateanDto cetatean;

            try
            {
                cetatean = _cetateanService.CautaCetatean(cnpCetateanTextBox.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            gridViewCetateni.DataSource = new[] {cetatean};
        }

        private void butonActualizareCetatean_Click(object sender, EventArgs e)
        {
            var cetatean = (CetateanDto)gridViewCetateni.SelectedRows[0].DataBoundItem;

            var form = new ActualizareCetateanForm(cetatean.Cnp);
            form.ShowDialog();

            cetatean = _cetateanService.CautaCetatean(cetatean.Cnp);

            gridViewCetateni.DataSource = new[] {cetatean};
        }
        #endregion
    }
}
