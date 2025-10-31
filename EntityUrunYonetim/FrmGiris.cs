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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        EntityUrunYonetimiDBEntities1 db = new EntityUrunYonetimiDBEntities1();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            var kullanici = from x in db.Tbl_Admin
                            where x.Kullanıcı == TxtKullaniciAd.Text && x.Sifre == TxtSifre.Text
                            select x;
            if (kullanici.Any())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");

            }
        }
    }
}
