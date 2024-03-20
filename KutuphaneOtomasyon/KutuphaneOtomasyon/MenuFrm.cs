using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class MenuFrm : Form
    {
        public MenuFrm()
        {
            InitializeComponent();
        }

        private void yeniKullaniciBtn_Click(object sender, EventArgs e)
        {
            YeniKullaniciFrm yeniKullaniciFrm = new YeniKullaniciFrm();
            
            yeniKullaniciFrm.Show();
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
           
             Application.Exit();
           
        }

        private void uyelerBtn_Click(object sender, EventArgs e)
        {
           
            UyeIslem uyeIslem = new UyeIslem();
            uyeIslem.Show();
        }
    }
}
