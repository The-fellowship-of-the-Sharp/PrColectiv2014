﻿using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using GraveyardManagement.Controller;
using GraveyardManagement.Model.Cerere;
using GraveyardManagement.Model.ModelCetatean;
using GraveyardManagement.Model.ModelProgramareInmormantare;
using GraveyardManagement.View.Cerere;
using GraveyardManagement.View.Cetatean;
using GraveyardManagement.View.ProgramareInmormantari;
using GraveyardManagement.View.Decedat;
using GraveyardManagement.Model.ModelDecedat;
using GraveyardManagement.Model.Contract;
using GraveyardManagement.View.Contract;

namespace GraveyardManagement.View
{
    public partial class MainForm : Form
    {
        private ProgramareInmormantareService _programareInmormantare;
        private ControllerMormant _mormant;
        private CetateanService _cetateanService;
        private DecedatService _decedatService;
        private readonly StatisticiService _statisticiService = new StatisticiService();
        private CerereService _cerereService;
        private ContractService _contractService;
        private readonly DecedatiFaraApartinatoriService _faraApartinatoriService = new DecedatiFaraApartinatoriService();

        private delegate void ThreadFunction();

        private void InitializeWithThreads()
        {
            var threadFunctions = new ThreadFunction[]
            {
                InitializeUiProgramari,
                InitializeUiMorminte,
                InitializeDecedati,
                InitializeCetateni,
                InitializeCereri,
                InitializeContracte

            };
            var threads = new List<Thread>();

            foreach (var thread in threadFunctions.Select(threadFunction => new Thread(new ThreadStart(threadFunction))))
            {
                threads.Add(thread);
                thread.Start();
            }
            foreach (var thread in threads)
            {
                thread.Join();
            }
        }
        private void InitializeWithoutThreads()
        {
            InitializeUiProgramari();
            InitializeUiMorminte();
            InitializeDecedati();
            InitializeCetateni();
            InitializeCereri();
            InitializeContracte();
        }

        public MainForm()
        {
            this.Show();
            InitializeComponent();

            /* 
             Initializarea multithreaded cateodata crapa la InitializeDecedati() la apelul functiei _decedatService.TotiDecedatii() in linia
             var alocare = _entities.AlocareLoc.FirstOrDefault(a => a.cnpDecedat == decedat.cnp);
             din cauza a NullReferenceException dar n-am reusit sa-mi dau seama ce anume ii null
             */
            //InitializeWithThreads(); 

            InitializeWithoutThreads();
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
                var yFirstLine = (cnpTextBox.Location.Y + adaugaButton.Location.Y + adaugaButton.Size.Height) / 2;
                var ySecondLine = (actualizaButton.Location.Y + endDatePicker.Location.Y + endDatePicker.Size.Height) / 2;
                g.DrawLine(Pens.Black, new Point(xStart, yFirstLine), new Point(xEnd, yFirstLine));
                g.DrawLine(Pens.Black, new Point(xStart, ySecondLine), new Point(xEnd, ySecondLine));
            };
        }

        private void InitializeUiMorminte()
        {
            var cimitire = Global.GlobalVariables.Utils.IncarcaToateCimitirele();
            foreach (var it in cimitire)
            {
                filtruCimitir.Items.Add(it);
            }
            filtruCimitir.DisplayMember = "Name";
            this._mormant = new ControllerMormant();
            loadIntoMorminte(this._mormant.CautaMormantDupaLoc("", "", null, false));
            morminteView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void loadIntoMorminte(List<Model.Mormant.MormantDTO> list)
        {
            morminteView.Rows.Clear();
            foreach (var it in list)
            {
                morminteView.Rows.Add(it.Cimitir, it.Parcela, it.NumarMormant,
                    it.DataExpirare, it.Suprafata, it.EsteMonument, it.CnpDecedat, it.NumeDecedat, it.PrenumeDecedat, it.Id);
            }
        }

        private void cautaDupaDecedatButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cnp = cnpTextBox.Text;
                var programare = _programareInmormantare.CautaProgramareInmormantareDupaCNP(cnp);
                if (programare != null)
                {
                    programariView.DataSource = new[] { programare };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (selected == null) return;
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
                parcela.Trim().Equals("") || cimitir.Equals(@"Cimitir") || religie.Equals(@"Religie")) return;
            try
            {
                _programareInmormantare.AdaugaProgramareInmormantare(cnp, cimitir, parcela, nrMormant, data, religie);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Eroare la adaugat", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            programariView.DataSource = null;
        }

        private void adaugaMorminte_Click(object sender, System.EventArgs e)
        {
            var adauga = new View.Mormant.AdaugaMormant();
            var result = adauga.ShowDialog();
            if (result == DialogResult.Cancel) return;
            var cimitir = adauga.getCimitir();
            if (cimitir == null)
            {
                MessageBox.Show("Nu a fost selectat nici un cimitir");
                return;
            }
            var parcela = adauga.getParcela();
            int numar = -1;
            try
            {
                numar = Convert.ToInt32(adauga.GetNumar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Numarul de mormant introdus este invalid.");
                return;
            }

            var esteMonument = adauga.GetMonument();

            try
            {
                _mormant.AdaugaMormant(cimitir.Id, cimitir.Name, parcela, numar, esteMonument);
                loadIntoMorminte(this._mormant.CautaMormantDupaLoc("", "", null, false));
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                loadIntoMorminte(this._mormant.CautaMormantDupaDecedat(filtruCNP.Text));
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cautaLoc_Click(object sender, System.EventArgs e)
        {
            //Sry for the crappy code, vroiam sa fie si searchable dupa nume dar si selectable
            string numeCimitir;
            try {
                numeCimitir = ((Model.Utils.CimitirDTO)filtruCimitir.SelectedItem).Name;
            } catch(System.Exception err) {
                numeCimitir = filtruCimitir.Text;
            }
            try
            {
                loadIntoMorminte(this._mormant.CautaMormantDupaLoc(
                    numeCimitir,
                    filtruParcela.Text,
                    (filtruNumar.Text.Length == 0 ? null : filtruNumar.Text),
                    monumentCheckBox.Checked));
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                this._mormant.ElibereazaMormant(
                    (int)morminteView.SelectedRows.Cast<DataGridViewRow>().First().Cells[9].Value
                    );
            }
            catch (Exception)
            {
                MessageBox.Show(@"Mormantul nu are decedat!");
            }
            loadIntoMorminte(this._mormant.CautaMormantDupaLoc("", "", null, false));
        }

        private void loadIntoDecedato(List<Model.ModelDecedat.DecedatDTO> listDecedati)
        {
            decedatGridView.Rows.Clear();
            foreach (var decedat in listDecedati)
            {
                decedatGridView.Rows.Add(decedat.Cnp, decedat.Nume, decedat.Prenume);
            }
        }


        #endregion

        #region Decedati

        private void InitializeDecedati()
        {
            _decedatService = new DecedatService();

            decedatGridView.DataSource = _decedatService.TotiDecedatii();
        }

        private void buttonAdauga_Click(object sender, System.EventArgs e)
        {
            var form = new AdaugareDecedat();
            form.ShowDialog();
            this.InitializeDecedati();
        }

        private void atribuieButton_Click(object sender, EventArgs e)
        {
            string decedat = "";

            for (int i = 0; i < decedatGridView.SelectedRows.Cast<DataGridViewRow>().First().Cells.Count - 1; i++)
            {
                decedat += (string)decedatGridView.SelectedRows.Cast<DataGridViewRow>().First().Cells[i].Value.ToString() + " ";
            }

            var form = new AtribuireMormant(decedat);

            if (decedatGridView.SelectedRows.Cast<DataGridViewRow>().First().Cells[3].Value.ToString() != String.Empty)
            {
                MessageBox.Show("Decedatul selectat are deja un mormant atribuit! Va rugam sa selectati alt decedat si sa incercati din nou!");
            }
            else
            {
                form.ShowDialog();
                decedatGridView.DataSource = _decedatService.TotiDecedatii();
            }
        }

        private void buttonCauta_Click(object sender, System.EventArgs e)
        {
            DecedatDTO decedat;

            try
            {
                decedat = _decedatService.CautaDecedat(CNPwatermarkTextBox.Text.Trim());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var l = new List<DecedatDTO>();
            l.Add(decedat);
            BindingSource bs = new BindingSource();
            bs.DataSource = l;

            decedatGridView.DataSource = bs;
            /*decedatGridView.Rows.Clear();
            decedatGridView.Rows.Add(decedat.Cnp, decedat.Nume, decedat.Prenume, decedat.Cimitir, decedat.Parcela, decedat.Numar);
            */
            if (decedat.Cimitir == "")
            {
                nuAreAlocatLabel.Visible = true;
            }
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

            gridViewCetateni.DataSource = new[] { cetatean };
        }

        private void butonActualizareCetatean_Click(object sender, EventArgs e)
        {
            if (gridViewCetateni.SelectedRows.Count <= 0)
                return;

            var cetatean = (CetateanDto)gridViewCetateni.SelectedRows[0].DataBoundItem;

            var form = new ActualizareCetateanForm(cetatean.Cnp);
            form.ShowDialog();

            cetatean = _cetateanService.CautaCetatean(cetatean.Cnp);

            gridViewCetateni.DataSource = new[] { cetatean };
        }

        private void butonCereriCetatean_Click(object sender, EventArgs e)
        {
            if (gridViewCetateni.SelectedRows.Count <= 0)
                return;

            var cetatean = (CetateanDto)gridViewCetateni.SelectedRows[0].DataBoundItem;

            var form = new VizualizareCereriPentruCetatean(cetatean.Cnp);

            form.ShowDialog();
        }

        private void butonContracteCetatean_Click(object sender, EventArgs e)
        {
            if (gridViewCetateni.SelectedRows.Count <= 0)
                return;

            var cetatean = (CetateanDto)gridViewCetateni.SelectedRows[0].DataBoundItem;

            var form = new VizualizareContractePentruCetatean(cetatean.Cnp);

            form.ShowDialog();
        }
        #endregion


        #region Contracte

        private void InitializeContracte()
        {
            _contractService = new ContractService();
        }


        private void addContractBtn_Click(object sender, EventArgs e)
        {
            var form = new AdaugareContractForm();
            form.ShowDialog();
        }

        private void cautaContractebtn_Click(object sender, EventArgs e)
        {
            string CNP;

            try
            {
                CNP = cnpTextBox1.Text.ToString();
                if (CNP.Length != 13)
                {
                    throw new Exception("CNP nu are 13 cifre!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CNP-ul introdus este invalid!");
                return;
            }


            List<ContractDto> contract;
            try
            {
                contract = _contractService.CautaContracte(CNP);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            girdViewContracte.DataSource =  contract ;
        }

        private void updateContractBtn_Click(object sender, EventArgs e)
        {
            if (girdViewContracte.SelectedRows.Count <= 0)
                return;

            var contract = (ContractDto)girdViewContracte.SelectedRows[0].DataBoundItem;

            var form = new ActualizareContract(contract.Numar);
            form.ShowDialog();

            contract = _contractService.CautaContract(contract.Numar);

            girdViewContracte.DataSource = new[] { contract };
        }

        private void deleteContractbtn_Click(object sender, EventArgs e)
        {
            if (girdViewContracte.SelectedRows.Count <= 0)
                return;

            var contract = (ContractDto)girdViewContracte.SelectedRows[0].DataBoundItem;

            _contractService.StergeContract(contract.Numar);

        }

        #endregion

        #region Statistici
        private void expiraInAnulCurrentButton_Click(object sender, EventArgs e)
        {
            statisticiGridView.DataSource = _statisticiService.SelectMorminteCareExpiraInAnulCurrent();
        }

        private void expiratePeAniButton_Click(object sender, EventArgs e)
        {
            statisticiGridView.DataSource = _statisticiService.SelectMorminteExpiratePeAni();
        }

        private void platiteInAcestAnButton_Click(object sender, EventArgs e)
        {
            statisticiGridView.DataSource = _statisticiService.SelectMormintePlatiteInAnulCurrent();
        }

        #endregion

        #region Cereri

        private void InitializeCereri()
        {
            _cerereService = new CerereService();

            gridViewCereri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void butonAdaugareCerere_Click(object sender, EventArgs e)
        {
            var form = new AdaugareCerereForm();
            form.ShowDialog();
        }

        private void butonActualizareCerere_Click(object sender, EventArgs e)
        {
            if (gridViewCereri.SelectedRows.Count <= 0)
                return;

            var cerere = (CerereDto)gridViewCereri.SelectedRows[0].DataBoundItem;

            var form = new ActualizareCerereForm(cerere.Numar);
            form.ShowDialog();

            cerere = _cerereService.CautaCerere(cerere.Numar);

            gridViewCereri.DataSource = new[] { cerere };
        }

        private void btn_CautaCerereDupaNumar_Click(object sender, EventArgs e)
        {
            int nrInfocet;

            try
            {
                nrInfocet = Convert.ToInt32(nrInfocetCerereTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numarul Infocet introdus este invalid!");
                return;
            }
            CerereDto cerere;
            try
            {
                cerere = _cerereService.CautaCerereDupaNumar(nrInfocet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            gridViewCereri.DataSource = new[] { cerere };
        }
        private void btn_CautaCerereDupaData_Click(object sender, EventArgs e)
        {
            var dataInregistrare = dataInregistrarePicker.Value;

            List<CerereDto> cereri;
            try
            {
                cereri = _cerereService.CautaCerereDupaData(dataInregistrare);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            gridViewCereri.DataSource = cereri;
        }/*
        private void butonCautaCerere_Click(object sender, EventArgs e)
        {
            int nrInfocet;

            try
            {
                nrInfocet = Convert.ToInt32(nrInfocetCerereTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Numarul Infocet introdus este invalid!");
                return;
            }


            var dataInregistrare = dataInregistrarePicker.Value;

            CerereDto cerere;
            try
            {
                cerere = _cerereService.CautaCerere(nrInfocet, dataInregistrare);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            gridViewCereri.DataSource = new[] { cerere };
        }
        */
        private void butonStergereCerere_Click(object sender, EventArgs e)
        {
            if (gridViewCereri.SelectedRows.Count <= 0)
                return;

            var cerere = (CerereDto)gridViewCereri.SelectedRows[0].DataBoundItem;

            _cerereService.StergeCerere(cerere.Numar);

            gridViewCereri.DataSource = null;
        }

        #endregion

        #region DecedatiFaraApartinatori
        private void cautaDecedatFaraApartinatoriButton_Click(object sender, EventArgs e)
        {
            var cnpDecedat = cnpDecedatFaraApartinatorText.Text;
            if (cnpDecedat != "")
            {
                decedatiFaraApartinatoriGrid.DataSource = _faraApartinatoriService.CautaDupaCNPDecedat(cnpDecedat);
            }
            else
            {
                MessageBox.Show(@"Va rugam introduceti un CNP!", @"CNP nespecificat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cautaDupaNrSolicitareButton_Click(object sender, EventArgs e)
        {
            var nrSolicitare = nrSolicitareText.Text;
            if (nrSolicitare != "")
            {
                try
                {
                    decedatiFaraApartinatoriGrid.DataSource = _faraApartinatoriService.CautaDupaNrSolicitare(Convert.ToInt32(nrSolicitare));
                }
                catch (FormatException)
                {
                    MessageBox.Show(@"Va rugam introduceti un numar valid!", @"Numar invalid",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Va rugam introduceti un numar!", @"Numar nespecificat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cautaDupaNrAdeverintaButton_Click(object sender, EventArgs e)
        {
            var nrAdeverinta = nrAdeverintaText.Text;
            if (nrAdeverinta != "")
            {
                try
                {
                    decedatiFaraApartinatoriGrid.DataSource = _faraApartinatoriService.CautaDupaNrAdeverinta(Convert.ToInt32(nrAdeverinta));
                }
                catch (FormatException)
                {
                    MessageBox.Show(@"Va rugam introduceti un numar valid!", @"Numar invalid",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Va rugam introduceti un numar!", @"Numar nespecificat",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'necropolisDataSet.ContractConcesiune' table. You can move, or remove it, as needed.
            this.contractConcesiuneTableAdapter.Fill(this.necropolisDataSet.ContractConcesiune);

        }

    }
}
