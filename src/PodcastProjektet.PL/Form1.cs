
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
                    var listViewItem = new ListViewItem(avsnitt.Titel); // Använd avsnittets titel
                    listViewItem.SubItems.Add(avsnitt.Beskrivning); // Beskrivning


                    listView2.Items.Add(listViewItem);
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Hämta den valda raden
                var selectedItem = listView1.SelectedItems[0];

                // Hämta Podd-objektet från Tag
                var podd = selectedItem.Tag as Podd;

                // Kontrollera att podd inte är null
                if (podd != null)
                {
                    textBox6.Text = podd.Beskrivning;

                    UpdateAvsnittListView(podd.AvsnittLista);
                    

                    // Om det finns avsnitt, välj det första avsnittet och sätt dess beskrivning i textBox6
                    if (podd.AvsnittLista.Count > 0)
                    {
                        textBox6.Text = podd.AvsnittLista[0].Beskrivning; // Sätt beskrivningen i textBox6
                    }
                    else
                    {
                        textBox6.Text = "Inga avsnitt tillgängliga."; // Meddelande om inga avsnitt
                    }
                }
            }


        }



        private void button4_Click(object sender, EventArgs e)
        {
            string rssUrl = textBox2.Text; // Anta att du har en TextBox för RSS-URL
            


            // Skapa en instans av PodcastRepository
            var podcastRepo = new PodcastRepository();

            // Anropa AddNewPoddFeed-metoden
            bool success = podcastRepo.AddNewPoddFeed(rssUrl);

            // Informera användaren om resultatet
            if (success)
            {
                MessageBox.Show("Podd-flöde tillagt framgångsrikt!");
                UpdateListView(podcastRepo);

                var newPodd = podcastRepo.GetAll().Last(); // Hämta den senast tillagda podden
                UpdateAvsnittListView(newPodd.AvsnittLista); // Uppdatera listView2 med avsnitt
            }



            else
            {
                MessageBox.Show("Ett fel inträffade vid tillägg av podd-flödet.");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView(PodcastRepository podcastRepo)
        {
            // Rensa nuvarande innehåll i ListView
            listView1.Items.Clear();

            listView2.Items.Clear();

            // Hämta alla poddar och fyll i ListView
            List<Podd> poddar = podcastRepo.GetAll();

            foreach (var podd in poddar)
            {
                // Skapa en ny ListViewItem med poddnamnet
                var listViewItem = new ListViewItem(podd.AntalAvsnitt); // Använd Podd.title eller CustomName

                listViewItem.SubItems.Add(podd.Titel);

                listViewItem.SubItems.Add(podd.Kategori);

                listViewItem.SubItems.Add(podd.Namn);

                listViewItem.Tag = podd;

                listView1.Items.Add(listViewItem);

                
            }
            if (poddar.Count > 0)
            {
                var firstPodd = poddar[0]; // Hämta den första podden
                UpdateAvsnittListView(firstPodd.AvsnittLista); // Uppdatera avsnitt i listView2
            }

            else
            {
                // Meddela användaren om inga avsnitt finns
                // Du kan även välja att visa ett meddelande i listView2
                listView2.Items.Clear(); // Rensa avsnittlistan
                listView2.Items.Add(new ListViewItem("Inga avsnitt tillgängliga för "));
            }
        
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Kontrollera om en podd är vald i ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Hämta den valda podden
                var selectedItem = listView1.SelectedItems[0];

                // Hämta det nya namnet från textBox1
                string newName = textBox1.Text;

                // Om det finns ett nytt namn, uppdatera namnet
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    // Anta att namnet finns i den sista kolumnen, justera index om det behövs
                    selectedItem.SubItems[3].Text = newName; // Index 3 om namnet är i den fjärde kolumnen

                    // Om du även vill uppdatera datakällan, kan du göra det här
                    var podd = (Podd)selectedItem.Tag; // Anta att du har sparat Podd-objektet i Tag
                    podd.Namn = newName; // Uppdatera Podd-objektet

                    // Här kan du också spara ändringen till databasen om det behövs
                    // podcastRepo.SaveChanges(); // Om SaveChanges-metoden finns och behövs
                }

            }
            else
            {
                MessageBox.Show("Vänligen välj en podd att uppdatera.");
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


