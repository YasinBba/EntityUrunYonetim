using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EntityUrunYonetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       EntityUrunYonetimiDBEntities1 db = new EntityUrunYonetimiDBEntities1();  
        private void BtnListele_Click(object sender, EventArgs e)
        {
            
            var kategoriler = db.Tbl_Category.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
           Tbl_Category t = new Tbl_Category();
            t.KategoriAd = TxtKategoriAd.Text;
            db.Tbl_Category.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtKategoriId.Text);
            var kategori = db.Tbl_Category.Find(id);
            db.Tbl_Category.Remove(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtKategoriId.Text);
            var kategori = db.Tbl_Category.Find(id);
            kategori.KategoriAd = TxtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtKategoriId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtKategoriAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
