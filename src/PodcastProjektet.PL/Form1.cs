
using PodcastProjektet.BLL;
using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;

namespace PodcastProjektet.PL
{
    public partial class Form1 : Form
    {
        private PodcastManager _podcastManager;
        public Form1()
        {
            InitializeComponent();
            _podcastManager = new PodcastManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(_podcastManager.getNamn());
            //test


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

        private void UpdateAvsnittListView(List<Avsnitt> avsnittLista)
        {
            {
                listView2.Items.Clear(); // Rensa nuvarande avsnitt

                foreach (var avsnitt in avsnittLista)
                {
                    var listViewItem = new ListViewItem(avsnitt.Titel); // Anv�nd avsnittets titel
                    listViewItem.SubItems.Add(avsnitt.Beskrivning); // Beskrivning


                    listView2.Items.Add(listViewItem);
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // H�mta den valda raden
                var selectedItem = listView1.SelectedItems[0];

                // H�mta Podd-objektet fr�n Tag
                var podd = selectedItem.Tag as Podd;

                // Kontrollera att podd inte �r null
                if (podd != null)
                {
                    textBox6.Text = podd.Beskrivning;

                    UpdateAvsnittListView(podd.AvsnittLista);
                    

                    // Om det finns avsnitt, v�lj det f�rsta avsnittet och s�tt dess beskrivning i textBox6
                    if (podd.AvsnittLista.Count > 0)
                    {
                        textBox6.Text = podd.AvsnittLista[0].Beskrivning; // S�tt beskrivningen i textBox6
                    }
                    else
                    {
                        textBox6.Text = "Inga avsnitt tillg�ngliga."; // Meddelande om inga avsnitt
                    }
                }
            }


        }



        private void button4_Click(object sender, EventArgs e)
        {
            string rssUrl = textBox2.Text; // Anta att du har en TextBox f�r RSS-URL
            


            // Skapa en instans av PodcastRepository
            var podcastRepo = new PodcastRepository();

            // Anropa AddNewPoddFeed-metoden
            bool success = podcastRepo.AddNewPoddFeed(rssUrl);

            // Informera anv�ndaren om resultatet
            if (success)
            {
                MessageBox.Show("Podd-fl�de tillagt framg�ngsrikt!");
                UpdateListView(podcastRepo);

                var newPodd = podcastRepo.GetAll().Last(); // H�mta den senast tillagda podden
                UpdateAvsnittListView(newPodd.AvsnittLista); // Uppdatera listView2 med avsnitt
            }



            else
            {
                MessageBox.Show("Ett fel intr�ffade vid till�gg av podd-fl�det.");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView(PodcastRepository podcastRepo)
        {
            // Rensa nuvarande inneh�ll i ListView
            listView1.Items.Clear();

            listView2.Items.Clear();

            // H�mta alla poddar och fyll i ListView
            List<Podd> poddar = podcastRepo.GetAll();

            foreach (var podd in poddar)
            {
                // Skapa en ny ListViewItem med poddnamnet
                var listViewItem = new ListViewItem(podd.AntalAvsnitt); // Anv�nd Podd.title eller CustomName

                listViewItem.SubItems.Add(podd.Titel);

                listViewItem.SubItems.Add(podd.Kategori);

                listViewItem.SubItems.Add(podd.Namn);

                listViewItem.Tag = podd;

                listView1.Items.Add(listViewItem);

                
            }
            if (poddar.Count > 0)
            {
                var firstPodd = poddar[0]; // H�mta den f�rsta podden
                UpdateAvsnittListView(firstPodd.AvsnittLista); // Uppdatera avsnitt i listView2
            }

            else
            {
                // Meddela anv�ndaren om inga avsnitt finns
                // Du kan �ven v�lja att visa ett meddelande i listView2
                listView2.Items.Clear(); // Rensa avsnittlistan
                listView2.Items.Add(new ListViewItem("Inga avsnitt tillg�ngliga f�r "));
            }
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Kontrollera om en podd �r vald i ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // H�mta den valda podden
                var selectedItem = listView1.SelectedItems[0];

                // H�mta det nya namnet fr�n textBox1
                string newName = textBox1.Text;

                // Om det finns ett nytt namn, uppdatera namnet
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    // Anta att namnet finns i den sista kolumnen, justera index om det beh�vs
                    selectedItem.SubItems[3].Text = newName; // Index 3 om namnet �r i den fj�rde kolumnen

                    // Om du �ven vill uppdatera datak�llan, kan du g�ra det h�r
                    var podd = (Podd)selectedItem.Tag; // Anta att du har sparat Podd-objektet i Tag
                    podd.Namn = newName; // Uppdatera Podd-objektet

                    // H�r kan du ocks� spara �ndringen till databasen om det beh�vs
                    // podcastRepo.SaveChanges(); // Om SaveChanges-metoden finns och beh�vs
                }

            }
            else
            {
                MessageBox.Show("V�nligen v�lj en podd att uppdatera.");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


