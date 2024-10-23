namespace PodcastProjektet.Models
{
    [Serializable]
    public class Kategori
    {
        public string KategoriNamn{ get; set; }
        public List<Podd> Poddar {  get; set; } 

        public Kategori(string kategoriNamn)
        {
            KategoriNamn = kategoriNamn;
            Poddar= new List<Podd>();
        }

        public Kategori() 
        { 

        }   
    }

    

}
