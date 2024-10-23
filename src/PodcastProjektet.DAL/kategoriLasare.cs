using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PodcastProjektet.DAL
{
    internal static class kategoriLasare
    {

        public static void textSkrivare()
        {
            string[] kategorier = { "Komedi", "Skräck", "Sport", "Vetenskap", "Teknologi" };

            using (FileStream fileStream = new FileStream("Kategori.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (string rad in kategorier)
                        writer.WriteLine(rad);
                }
            }
        }
        public static void nyTextSkrivare(string nyCategori)
        {
            using (FileStream fileStream = new FileStream("Kategori.txt", FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine(nyCategori);
                }
            }

        }

        public static List <String> textLasare()
        {
            List <string> result=new List<string>();    

            using (FileStream fileStream =new FileStream ("Kategori.txt", FileMode.Append, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(fileStream))
                {
                   string line=reader.ReadLine();
                while(line != null)
                    {
                        line = reader.ReadLine();
                        string kategori = new string(line);
                        result.Add(kategori);
                    }
                }
           
            }
            return result;

        }

        public static void RaderaKategori (string kategori)
        {
            var kategorier = File.ReadAllLines("Kategori.txt").ToList();
            if(kategorier.Contains(kategori))
            {
                kategorier.Remove(kategori);
                File.WriteAllLines("Kategori.txt", kategorier);
            }
        }

        public static void Uppdatera (string kategoriNamn, string nyttKategoriNamn)
        {
            var kategorier = File.ReadAllText("Kategori.txt");
            kategorier=kategorier.Replace(kategoriNamn, nyttKategoriNamn);
            File.WriteAllText("Kategori.txt", kategorier);
        }
    }
}
