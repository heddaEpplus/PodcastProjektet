namespace PodcastProjektet.Models
{
    [Serializable]
    public class Kategori
    {
        public Guid Id { get; set; }
        public string Namn{ get; set; }
        public List<Podd> Poddar {  get; set; } 

        public Kategori(string kategoriNamn)
        {
            Id = Guid.NewGuid();
            Namn = kategoriNamn;
            Poddar = new List<Podd>();
        }

        public Kategori() 
        { 

        }   
    }

    

}
