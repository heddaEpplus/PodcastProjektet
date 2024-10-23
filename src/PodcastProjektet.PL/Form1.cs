
using PodcastProjektet.BLL;
using PodcastProjektet.DAL;
using PodcastProjektet.DAL.Repository;
using PodcastProjektet.Models;

namespace PodcastProjektet.PL
{
    public partial class Form1 : Form
    {
        private PodcastManager _podcastManager;
        private PodcastRepository _podcastRepository;
        ListViewItem selectedItem;
        private PoddController _controller;

        public Form1(PodcastRepository poddrepo)
        {
            InitializeComponent();
            _podcastManager = new PodcastManager();
            _podcastRepository = poddrepo;
            UpdateListView();
             _controller = new PoddController();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            


            // Skapa en instans av PodcastRepository
            

            // Anropa AddNewPoddFeed-metoden
            bool success = _podcastRepository.AddNewPoddFeed(rssUrl);

            // Informera användaren om resultatet
            if (success)
            {
                MessageBox.Show("Podd-flöde tillagt framgångsrikt!");
                UpdateListView();

                var newPodd = _podcastRepository.GetAll().Last(); // Hämta den senast tillagda podden
                UpdateAvsnittListView(newPodd); // Uppdatera avsnitt i listView2
            }



            else
            {
                MessageBox.Show("Ett fel inträffade vid tillägg av podd-flödet.");
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateListView()
        {
            // Rensa nuvarande innehåll i ListView
            listView1.Items.Clear();

            listView2.Items.Clear();

            // Hämta alla poddar och fyll i ListView
            List<Podd> poddar = _podcastRepository.GetAll();

            

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
    }
}


