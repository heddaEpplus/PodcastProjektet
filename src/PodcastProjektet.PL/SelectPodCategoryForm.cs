using PodcastProjektet.BLL;
using PodcastProjektet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodcastProjektet.PL
{
    public partial class SelectPodCategoryForm : Form
    {
        PoddController _poddController;
        private List<Kategori> _kategorier = new List<Kategori>();
        private readonly Podd _podd;
        private readonly Form1 _parent;
        public SelectPodCategoryForm(Podd podd, Form1 parent)
        {
            _podd = podd;
            _parent = parent;
            _poddController = new PoddController();
            InitializeComponent();   
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var kategori = _kategorier[ComboBoxKategori.SelectedIndex];
            _poddController.UppdateraKategori(_podd.Id, kategori.Id);
            _parent.UpdateListView();
            Close();
        }

        private void SelectPodCategoryForm_Load(object sender, EventArgs e)
        {
            var categoryController = new KategoriController();
            _kategorier = categoryController.HamtaAllaKategorier();
            ComboBoxKategori.Items.Clear();
            foreach (var category in _kategorier)
            {
                ComboBoxKategori.Items.Add(category.Namn);
            }
        }
    }
}
