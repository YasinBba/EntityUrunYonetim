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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        EntityUrunYonetimiDBEntities1 db = new EntityUrunYonetimiDBEntities1();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Category.Count().ToString();
            label3.Text = db.Tbl_Product.Count().ToString();
            label5.Text = db.Tbl_Customer.Count(x => x.Durum==true).ToString();
            label7.Text = db.Tbl_Customer.Count(x => x.Durum == false).ToString();
           label11.Text = db.Tbl_Product.Sum(x => x.Stok).ToString();
            label21.Text = db.Tbl_Sales.Sum(x => x.Fiyat).ToString() + " TL ";
            label13.Text = (from x in db.Tbl_Product orderby x.Fiyat descending select x.UrunAd).FirstOrDefault();
            label15.Text = (from x in db.Tbl_Product orderby x.Fiyat ascending select x.UrunAd).FirstOrDefault();
            label9.Text = (from x in db.Tbl_Product
                           join y in db.Tbl_Category
                           on x.KategoriId equals y.KategoriId
                           where y.KategoriAd == "Beyaz Eşya"
                           select x).Count().ToString();
            label23.Text = db.Tbl_Product.Count(x => x.UrunAd == "Buzdolabı").ToString();
            label17.Text = (from x in db.Tbl_Customer select x.Sehir).Distinct().Count().ToString();
            label21.Text = db.MarkaGetir().FirstOrDefault();


        }
    }
}
