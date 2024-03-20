using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class UyeIslem : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=GÖKTUNÇ;Initial Catalog=KutuphaneDB;Integrated Security=True");
       private void ara()
        {
            string q = "SELECT * FROM Kitaplar WHERE KitapAdi LIKE '%" + kitapAdiTxt + "%' OR YazarAdi LIKE '%" + yazarAdiTxt + "%' OR YazarSoyadi LIKE '%" + yazarSoyadTxt + "%' OR ISBN LIKE '%" + ısbnTxt + "%' OR KitapTurKodu LIKE '%" + turKoduTxt + "%'";
            SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
        
        
        private void verileriGoster()
        {
           
            
                string q = "SELECT * FROM Kitaplar";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            
        }
        public UyeIslem()
        {
            InitializeComponent();
           
        }
       
  
        private void ekleBtn_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar (KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES (@KitapAdi,@YazarAdi,@YazarSoyadi,@ISBN,@Durum,@KitapTurKodu)", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("@KitapAdi", kitapAdiTxt.Text);
                cmd.Parameters.AddWithValue("@YazarAdi", yazarAdiTxt.Text);
                cmd.Parameters.AddWithValue("@YazarSoyadi", yazarSoyadTxt.Text);
                cmd.Parameters.AddWithValue("@ISBN", ısbnTxt.Text);
                cmd.Parameters.AddWithValue("@Durum", "False");
                cmd.Parameters.AddWithValue("@KitapTurKodu", turKoduTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap eklendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenemedi." + ex.Message);
            }
            finally { baglanti.Close(); }
        }

        private void UyeIslem_Load(object sender, EventArgs e)
        {
            ıdTxt.Text = "-";
             
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bedelLbl.Text = "0";
            int secilenSatir = dataGridView1.SelectedCells[0].RowIndex; 
            ıdTxt.Text = secilenSatir.ToString();
            ıdTxt.Text = dataGridView1.Rows[secilenSatir].Cells["ID"].Value.ToString();

            kitapAdiTxt.Text = dataGridView1.Rows[secilenSatir].Cells[1].Value.ToString();
            yazarAdiTxt.Text = dataGridView1.Rows[secilenSatir].Cells[2].Value.ToString();
            yazarSoyadTxt.Text = dataGridView1.Rows[secilenSatir].Cells[3].Value.ToString();
            ısbnTxt.Text = dataGridView1.Rows[secilenSatir].Cells[4].Value.ToString();
            turKoduTxt.Text = dataGridView1.Rows[secilenSatir].Cells[8].Value.ToString();

            alanAdiTxt.Text = dataGridView1.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridView1.Rows[secilenSatir].Cells[7].Value.ToString() != DBNull.Value.ToString())
            dateTimePicker1.Text = dataGridView1.Rows[secilenSatir].Cells[7].Value.ToString();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET KitapAdi=@KitapAdi,YazarAdi=@YazarAdi,YazarSoyadi=@YazarSoyadi,ISBN=@ISBN,KitapTurKodu=@KitapTurKodu WHERE ID=@KitapID", baglanti);
                cmd.Parameters.AddWithValue("@KitapAdi", kitapAdiTxt.Text);
                cmd.Parameters.AddWithValue("@YazarAdi", yazarAdiTxt.Text);
                cmd.Parameters.AddWithValue("@YazarSoyadi", yazarSoyadTxt.Text);
                cmd.Parameters.AddWithValue("@ISBN", ısbnTxt.Text);
                cmd.Parameters.AddWithValue("@KitapTurKodu", turKoduTxt.Text);
                cmd.Parameters.AddWithValue("@KitapID", ıdTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap güncellendi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenemedi." + ex.Message);
            }
            finally { baglanti.Close(); }
          


        }

        private void verilerBtn_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ıdTxt.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET OduncAlan = @OduncAlan, OduncAlmaTarihi = @OduncTarih, Durum = @durum WHERE ID=@KitapID", baglanti);
                    cmd.Parameters.AddWithValue("@OduncAlan", alanAdiTxt.Text);
                    cmd.Parameters.AddWithValue("@OduncTarih",SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    cmd.Parameters.AddWithValue("@durum", "False");
                    cmd.Parameters.AddWithValue("@KitapID", ıdTxt.Text);
                    cmd.ExecuteNonQuery();

                
                    MessageBox.Show("Kitap güncellendi.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap güncellenemedi." + ex.Message);
                }
                finally { baglanti.Close(); }

            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz !");
            }
        }

        private void gecikmeBtn_Click(object sender, EventArgs e)
        {
            if(ıdTxt.Text != "-")
            {
                try
                {
                   
                    DateTime bugun = DateTime.Now;
                    int gecikme = (bugun - dateTimePicker1.Value.Date).Days;
                    if (gecikme > 10)
                    {
                        int gecikmeBedeli = (gecikme - 10) * 2;
                        bedelLbl.Text = gecikmeBedeli.ToString();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata : " + ex.Message);
                }
                finally { }
            }
        }

        private void iadeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET OduncAlan = @OduncAlan, OduncAlmaTarihi = @OduncTarih, Durum = @durum WHERE ID=@KitapID", baglanti);
                cmd.Parameters.AddWithValue("@OduncAlan", DBNull.Value);
                cmd.Parameters.AddWithValue("@OduncTarih", DBNull.Value);
                cmd.Parameters.AddWithValue("@durum", "False");
                cmd.Parameters.AddWithValue("@KitapID", ıdTxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kitap iade edildi.");
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap iade edilemedi." + ex.Message);
            }
            finally { baglanti.Close(); }
         

        }

        private void temizlerBtn_Click(object sender, EventArgs e)
        {
            ıdTxt.Text = "-";
            kitapAdiTxt.Text = "";
            yazarAdiTxt.Text = "";
            yazarSoyadTxt.Text = "";
            ısbnTxt.Text = "";
            turKoduTxt.Text = "";
            alanAdiTxt.Text = "";
            bedelLbl.Text = "0";
           
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (ıdTxt.Text != "-")
            {

            }
            else
            {
                   MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz !");
                return;
            }
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kitaplar Where ID = @P1", baglanti);
                cmd.Parameters.AddWithValue("@P1", ıdTxt.Text);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Kitap silindi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap silinmedi." + ex.Message);
            }
            finally { baglanti.Close(); }
            verileriGoster();
            temizlerBtn_Click(sender, e);
        }
    }
}
