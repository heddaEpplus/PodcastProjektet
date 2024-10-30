
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
        private PodcastManager _podcastManager;

        ListViewItem selectedItem;
        private PoddController _controller;
        private KategoriController _kategoriController;
        private ValideringsController _valideringsController;
        List<Podd> _poddar;
        List<Kategori> _kategorier;

        public Form1()
        {
            InitializeComponent();
            _podcastManager = new PodcastManager();


            _controller = new PoddController();
            _kategoriController = new KategoriController();

            _valideringsController = new ValideringsController();
            //UpdateKategoriList();
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
                // Hämta den valda raden
                var selectedItem = listView1.SelectedItems[0];

                // Hämta Podd-objektet från Tag
                var podd = selectedItem.Tag as Podd;

                UpdateAvsnittListView(podd);


            }


        }



        private void button4_Click(object sender, EventArgs e)
        {
            string rssUrl = textBox2.Text; // Anta att du har en TextBox för RSS-URL



            if (_valideringsController.KollaOmPoddFinns(rssUrl))
            {
                MessageBox.Show("Denna podd finns redan!", "", MessageBoxButtons.OK);
                return;
            }

            if (!_valideringsController.KollaGiltigUrl(rssUrl))
            {
                MessageBox.Show("Ogiltigt URL format!", "", MessageBoxButtons.OK);
                return;
            }


            _controller.AddNewPoddFromRSS(rssUrl);
            var newPodd = _controller.GetAllPodcasts().Last();
            UpdateListView();// Hämta den senast tillagda podden
            UpdateAvsnittListView(newPodd); // Uppdatera avsnitt i listView2











        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateListView()
        {
            // Rensa nuvarande innehåll i ListView
            listView1.Items.Clear();

            listView2.Items.Clear();

            // Hämta alla poddar och fyll i ListView
            _poddar = _controller.GetAllPodcasts();



            foreach (var podd in _poddar)
            {
                // Skapa en ny ListViewItem med poddnamnet
                var listViewItem = new ListViewItem(podd.AntalAvsnitt); // Använd Podd.title eller CustomName

                listViewItem.SubItems.Add(podd.Titel);

                //listViewItem.SubItems.Add(podd.Kategori);
                listViewItem.SubItems.Add(podd.KategoriNamn);

                listViewItem.SubItems.Add(podd.Namn);

                listViewItem.Tag = podd;



                listView1.Items.Add(listViewItem);


            }
            if (_poddar.Count > 0)
            {
                var firstPodd = _poddar[0]; // Hämta den första podden
                UpdateAvsnittListView(firstPodd); // Uppdatera avsnitt i listView2
            }

            else
            {
                // Meddela användaren om inga avsnitt finns
                // Du kan även välja att visa ett meddelande i listView2
                listView2.Items.Clear(); // Rensa avsnittlistan
                listView2.Items.Add(new ListViewItem("Inga avsnitt tillgängliga för "));
            }

        }



        private void UpdateAvsnittListView(Podd selectedPodd)
        {
            listView2.Items.Clear(); // Rensa tidigare avsnitt

            // Hämta avsnitt för den valda podden
            var avsnittLista = selectedPodd.AvsnittLista; // Hämta avsnitt från den valda podden

            if (avsnittLista.Count > 0)
            {
                foreach (var avsnitt in avsnittLista)
                {
                    // Skapa en ListViewItem för varje avsnitt
                    ListViewItem avsnittItem = new ListViewItem(avsnitt.Titel); // Visa avsnittets titel
                    avsnittItem.SubItems.Add(avsnitt.Beskrivning); // Lägg till avsnittets beskrivning
                    listView2.Items.Add(avsnittItem); // Lägg till avsnittet i listView2

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

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];
                string nyttNamn = textBox1.Text;
                string poddTitle = selectedItem.SubItems[1].Text;

                // Om det finns ett nytt namn, kontrollera att det inte redan finns
                if (!string.IsNullOrWhiteSpace(nyttNamn))
                {
                    // Kontrollera om namnet redan finns
                    if (_valideringsController.KollaOmNamnFinns(nyttNamn))
                    {
                        MessageBox.Show("Namnet du angett finns redan!", "", MessageBoxButtons.OK);
                        return; // Avbryt om namnet redan finns
                    }

                    // Om valideringen går igenom, uppdatera namnet
                    selectedItem.SubItems[3].Text = nyttNamn; // Index 3 om namnet är i den fjärde kolumnen

                    // Uppdatera datakällan
                    var podd = (Podd)selectedItem.Tag; // Anta att du har sparat Podd-objektet i Tag
                    podd.Namn = nyttNamn; // Uppdatera Podd-objektet

                    // Spara ändringar i databasen
                    _controller.UpdatePodd(poddTitle, nyttNamn);
                    UpdateListView();

                    // Visa ett meddelande till användaren om att uppdateringen sparades.
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

            // Töm den befintliga ListView2 för att visa ny data


            // Lägg till varje beskrivning som en ny rad i ListView2
            foreach (var beskrivning in beskrivningar)
            {
                ListViewItem item = new ListViewItem(beskrivning);
                listView2.Items.Add(item);


            }


            if (listView2.SelectedItems.Count > 0)
            {
                // Hämta det valda objektet
                ListViewItem selectedItem = listView2.SelectedItems[0];

                // Hämta avsnittsbeskrivningen från det valda objektet
                string avsnittsBeskrivning = selectedItem.SubItems[1].Text; // Anta att beskrivningen ligger i det första subitem

                // Sätt avsnittsbeskrivningen i textBox6
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
                    try
                    {
                        _kategoriController.UppdateraKategori(kategoriId, nyKategoriNamn);
                        MessageBox.Show("Kategorin har uppdaterats framgångsrikt!");
                        UpdateKategoriList();
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
            UpdateKategoriList();
            UpdateKategoriComboBox();
            UpdateListView();

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
            List<Kategori> kategorier = _kategoriController.HamtaAllaKategorier();

            foreach (var kategori in kategorier)
            {
                ListViewItem item = new ListViewItem(kategori.Namn);
                KategoriListView.Items.Add(item);


            }
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Hämta den valda podden
                var selectedItem = listView1.SelectedItems[0];

                // Hämta titeln på den valda podden (justera index om titeln är i en annan kolumn)
                string poddTitle = selectedItem.SubItems[1].Text; // Index 3 om titeln finns i den fjärde kolumnen

                // Anropa delete-metoden med titeln som parameter
                _controller.DeletePodd(poddTitle);

                // Uppdatera ListView
                UpdateListView();

                // Visa meddelande till användaren om att podden har tagits bort
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
    }
}



