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
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace KutuphaneOtomasyon
    {
   
        public partial class YeniKullaniciFrm : Form
        {
            SqlConnection baglanti = new SqlConnection("Data Source=GÖKTUNÇ;Initial Catalog=KutuphaneDB;Integrated Security=True");
            public YeniKullaniciFrm()
            {
                InitializeComponent();
            }

            private void verileriGosterBtn_Click(object sender, EventArgs e)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Login", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
           


        }

    }
