using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=GÖKTUNÇ;Initial Catalog=KutuphaneDB;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            
//.Trim() metodu, bir stringin başında ve sonunda bulunan boşluk karakterlerini kaldırır.Bu, bir stringin başında ve sonunda bulunan gereksiz boşlukları temizlemek için kullanılır.
            try
            {
                
              
                {
                    baglanti.Open();
                    string query = "SELECT * FROM Login WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                    SqlCommand sqlCmd = new SqlCommand(query, baglanti);
                    sqlCmd.Parameters.AddWithValue("@KullaniciAdi", txtKullanici.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());
                    SqlDataReader dataReader = sqlCmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MenuFrm form= new MenuFrm();
                        this.Hide();
                        form.Show();
                        MessageBox.Show("Giriş başarılı!");

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen tekrar deneyin.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
