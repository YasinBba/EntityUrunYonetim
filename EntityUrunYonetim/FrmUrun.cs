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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        EntityUrunYonetimiDBEntities1 db = new EntityUrunYonetimiDBEntities1();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Product
                                        select new
                                        {
                                            x.UrunId,
                                            x.UrunAd,
                                            x.Marka,
                                            x.Stok,
                                            x.Fiyat,
                                            x.Durum,
                                            x.Tbl_Category.KategoriAd
                                        }).ToList();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Product t = new Tbl_Product();
            t.UrunAd = TxtUrunAd.Text;
            t.Marka = TxtMarka.Text;
            t.Stok = short.Parse(TxtStok.Text);
            t.Fiyat = decimal.Parse(TxtFiyat.Text);
            t.Durum = true;
            t.KategoriId = int.Parse(CmbKategori.SelectedValue.ToString());
            db.Tbl_Product.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            var urun = db.Tbl_Product.Find(id);
            db.Tbl_Product.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TxtID.Text);
            var urun = db.Tbl_Product.Find(id);
            urun.UrunAd = TxtUrunAd.Text;
            urun.Marka = TxtMarka.Text;
            urun.Stok = short.Parse(TxtStok.Text);
            urun.Fiyat = decimal.Parse(TxtFiyat.Text);
            urun.KategoriId = int.Parse(CmbKategori.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtStok.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbKategori.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {

            TxtID.Clear();
            TxtUrunAd.Clear();
            TxtMarka.Clear();
            TxtStok.Clear();
            TxtFiyat.Clear();
            CmbKategori.Text = "";
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Category
                               select new
                               {
                                   x.KategoriId,
                                   x.KategoriAd
                               }).ToList();
            CmbKategori.ValueMember = "KategoriId";
            CmbKategori.DisplayMember = "KategoriAd";
            CmbKategori.DataSource = kategoriler;

        }
    }
}
