using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10
{
    public partial class HizmetliEkle : Form
    {
        public HizmetliEkle()
        {
            InitializeComponent();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");
            SqlCommand com = new SqlCommand("insert into personel(tc,parola,ad,soyad,unvanId) values(@tc,@parola,@ad,@soyad,'3')", con);
            try
            {
                if (txt_tc.Text != null & txt_pass.Text != null & txt_ad.Text != null & txt_soyad.Text != null)
                {
                    com.Parameters.AddWithValue("tc", txt_tc.Text);
                    com.Parameters.AddWithValue("parola", txt_pass.Text);
                    com.Parameters.AddWithValue("ad", txt_ad.Text);
                    com.Parameters.AddWithValue("soyad", txt_soyad.Text);
                  
                }
                else
                {
                    MessageBox.Show("bu alanlar bos bırakılamaz.");
                }


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    int satır = com.ExecuteNonQuery();
                    MessageBox.Show("+" + satır + " hizmetli Kaydı basarıyla eklendi:)");

                }
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void HizmetliEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
