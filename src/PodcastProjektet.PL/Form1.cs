
using PodcastProjektet.BLL;
using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;
using PodcastProjektet.Models;
using System;
using System.Xml;

namespace PodcastProjektet.PL
{
    public partial class Form1 : Form
    {


        ListViewItem selectedItem;
        private PoddController _controller;
        private KategoriController _kategoriController;
        private ValideringsController _valideringsController;
        List<Podd> _poddar;
        List<Kategori> _kategorier;

        public Form1()
        {
            InitializeComponent();



            _controller = new PoddController();
            _kategoriController = new KategoriController();

            _valideringsController = new ValideringsController();

            UpdateListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListView.Items.Clear();
            _kategorier = _kategoriController.HamtaAllaKategorier();

            foreach (var kategori in _kategorier)
            {
                ListViewItem item = new ListViewItem(kategori.Namn);
                KategoriListView.Items.Add(item);
            }
            SorteraKategoriComboBox.Items.Clear();
            foreach (var kategori in _kategorier)
            {
                SorteraKategoriComboBox.Items.Add(kategori.Namn);
            }
            UpdateKategoriComboBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                var selectedItem = listView1.SelectedItems[0];


                var podd = selectedItem.Tag as Podd;

                UpdateAvsnittListView(podd);


            }


        }



        private async void button4_Click(object sender, EventArgs e)
        {
            string rssUrl = textBox2.Text;



            if (await _valideringsController.KollaOmPoddFinns(rssUrl))
            {
                MessageBox.Show("Denna podd finns redan!", "", MessageBoxButtons.OK);
                return;
            }

            if (!_valideringsController.KollaGiltigUrl(rssUrl))
            {
                MessageBox.Show("Ogiltigt URL format!", "", MessageBoxButtons.OK);
                return;
            }

            await _controller.AddNewPoddFromRSS(rssUrl);

            var podcasts = await _controller.GetAllPodcasts();
            var newPodd = podcasts.Last();
            UpdateListView();
            UpdateAvsnittListView(newPodd);











        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public async Task UpdateListView()
        {

            listView1.Items.Clear();

            listView2.Items.Clear();


            _poddar = await _controller.GetAllPodcasts();



            foreach (var podd in _poddar)
            {

                var listViewItem = new ListViewItem(podd.AntalAvsnitt);

                listViewItem.SubItems.Add(podd.Titel);


                listViewItem.SubItems.Add(podd.KategoriNamn);

                listViewItem.SubItems.Add(podd.Namn);

                listViewItem.Tag = podd;



                listView1.Items.Add(listViewItem);


            }
            if (_poddar.Count > 0)
            {
                var firstPodd = _poddar[0];
                await UpdateAvsnittListView(firstPodd);
            }

            else
            {

                listView2.Items.Clear();
                listView2.Items.Add(new ListViewItem("Inga avsnitt tillgängliga för "));
            }

        }



        private async Task UpdateAvsnittListView(Podd selectedPodd)
        {
            listView2.Items.Clear();

            var avsnittLista = selectedPodd.AvsnittLista;

            if (avsnittLista.Count > 0)
            {
                foreach (var avsnitt in avsnittLista)
                {

                    ListViewItem avsnittItem = new ListViewItem(avsnitt.Titel);
                    avsnittItem.SubItems.Add(avsnitt.Beskrivning);
                    listView2.Items.Add(avsnittItem);

                }
            }
            else
            {
                listView2.Items.Add(new ListViewItem("Inga avsnitt tillgängliga för " + selectedPodd.Titel));
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string nyttNamn = textBox1.Text;
                string poddTitle = selectedItem.SubItems[1].Text;


                if (!string.IsNullOrWhiteSpace(nyttNamn))
                {

                    if (await _valideringsController.KollaOmNamnFinns(nyttNamn))
                    {
                        MessageBox.Show("Namnet du angett finns redan!", "", MessageBoxButtons.OK);
                        return;
                    }


                    selectedItem.SubItems[3].Text = nyttNamn;


                    var podd = (Podd)selectedItem.Tag;
                    podd.Namn = nyttNamn;


                    await _controller.UpdatePodd(poddTitle, nyttNamn);
                    UpdateListView();


                    MessageBox.Show("Poddens namn har uppdaterats och sparats.");
                }
            }


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string poddId = "din-podd-id-här";

            List<string> beskrivningar = _controller.GetAllAvsnittBeskrivningarForPodd(poddId);


            foreach (var beskrivning in beskrivningar)
            {
                ListViewItem item = new ListViewItem(beskrivning);
                listView2.Items.Add(item);


            }


            if (listView2.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = listView2.SelectedItems[0];


                string avsnittsBeskrivning = selectedItem.SubItems[1].Text;


                textBox6.Text = avsnittsBeskrivning;
            }

        }

        private void LaggTillKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = KategoriTextBox.Text;

            if (!string.IsNullOrEmpty(nyKategori))
            {
                if (_valideringsController.KollaOmKategoriFinns(nyKategori) == true)
                {
                    MessageBox.Show(nyKategori + " finns redan registrerad som kategori.");
                    return;
                }

                try
                {
                    _kategoriController.LaggTillKategori(nyKategori);
                    MessageBox.Show("Kategorin har lagts till framgångsrikt!");
                    UpdateKategoriList();
                    UpdateKategoriComboBox();
                    UpdateListView();

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ange ett giltigt kategorinamn.");
            }
        }

        private void UpdateKategoriList()
        {
            KategoriListView.Items.Clear();

            var allaKategorier = _kategoriController.HamtaAllaKategorier();

            foreach (var kategori in allaKategorier)
            {
                ListViewItem item = new ListViewItem(kategori.Namn);
                KategoriListView.Items.Add(item);
            }
        }

        private void UpdateKategoriComboBox()
        {
            SorteraKategoriComboBox.Items.Clear();
            SorteraKategoriComboBox.Items.Add("Alla");
            _kategorier = _kategoriController.HamtaAllaKategorier();

            foreach (var kategori in _kategorier)
            {
                SorteraKategoriComboBox.Items.Add(kategori.Namn);
            }
        }

        private void AndraKategori_Click(object sender, EventArgs e)
        {
            if (KategoriListView.SelectedItems.Count > 0)
            {
                var selectedItem = KategoriListView.SelectedItems[0];
                var kategoriId = _kategorier[KategoriListView.SelectedIndices[0]].Id;
                string nyKategoriNamn = KategoriTextBox.Text;

                if (!string.IsNullOrWhiteSpace(nyKategoriNamn))
                {
                    if (_valideringsController.KollaOmKategoriFinns(nyKategoriNamn) == true)
                    {
                        MessageBox.Show($"Kategorin '{nyKategoriNamn}' finns redan. Välj ett annat namn.");
                        return;
                    }

                    try
                    {
                        _kategoriController.UppdateraKategori(kategoriId, nyKategoriNamn);
                        MessageBox.Show("Kategorin har uppdaterats framgångsrikt!");
                        UpdateKategoriList();
                        UpdateKategoriComboBox();
                        UpdateListView();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Både gammal och ny kategori måste anges.");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj en podd för att uppdatera dess kategori.");
            }

        }

        private void TaBortKategori_Click(object sender, EventArgs e)
        {
            string kategori = KategoriTextBox.Text;
            if (!string.IsNullOrWhiteSpace(kategori))
            {
                var confirmResult = MessageBox.Show(
                "Är du säker på att du vill ta bort kategorin?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
             );
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        _kategoriController.TaBort(kategori);
                        MessageBox.Show("Kategorin har tagits bort framgångsrikt!");
                        UpdateKategoriList();
                        UpdateKategoriComboBox();
                        UpdateListView();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ange ett giltigt kategorinamn för att ta bort.");
            }
        }

        private void KategoriListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (KategoriListView.SelectedItems.Count > 0)
            {
                var valdKategori = KategoriListView.SelectedItems[0].Text;
            }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                var selectedItem = listView1.SelectedItems[0];


                string poddTitle = selectedItem.SubItems[1].Text;


                _controller.DeletePodd(poddTitle);


                UpdateListView();


                MessageBox.Show($"Podd '{poddTitle}' har tagits bort.");
            }
            else
            {
                MessageBox.Show("Ingen podd är vald.");
            }
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            var podd = _poddar[listView1.SelectedIndices[0]];
            var form = new SelectPodCategoryForm(podd, this);
            form.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            if (SorteraKategoriComboBox.SelectedItem != null)
            {
                string valdKategori = SorteraKategoriComboBox.SelectedItem.ToString();

                if (valdKategori == "Alla")
                {
                    UpdateListView();
                }
                else
                {
                    FiltreraPoddarViaKategori(valdKategori);
                }
            }
            else
            {
                MessageBox.Show("Välj en kategori att filtrera efter.", "Ingen kategori vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FiltreraPoddarViaKategori(string valdKategori)
        {
            listView1.Items.Clear();

            var filteredPoddar = _poddar.Where(p => p.KategoriNamn == valdKategori).ToList();

            foreach (var podd in filteredPoddar)
            {
                var listViewItem = new ListViewItem(podd.AntalAvsnitt);
                listViewItem.SubItems.Add(podd.Titel);
                listViewItem.SubItems.Add(podd.KategoriNamn);
                listViewItem.SubItems.Add(podd.Namn);
                listViewItem.Tag = podd;

                listView1.Items.Add(listViewItem);
            }
        }

        private void SorteraKategoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



