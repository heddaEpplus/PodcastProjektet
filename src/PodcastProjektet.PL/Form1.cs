
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

            // H�mta alla poddar och fyll i ListView
            List<Podd> poddar = podcastRepo.GetAll();

            foreach (var podd in poddar)
            {
                // Skapa en ny ListViewItem med poddnamnet
                var listViewItem = new ListViewItem(podd.AntalAvsnitt); // Anv�nd Podd.title eller CustomName

                listViewItem.SubItems.Add(podd.Titel);

                listViewItem.SubItems.Add(podd.Kategori);

                listViewItem.SubItems.Add(podd.Namn);



                listView1.Items.Add(listViewItem);
            }
        }
    }
}


