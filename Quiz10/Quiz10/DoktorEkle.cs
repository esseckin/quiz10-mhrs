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
    public partial class DoktorEkle : Form
    {

        public DoktorEkle()
        {
            InitializeComponent();
        }

        private void btn_doktorekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");
            SqlCommand com = new SqlCommand("insert into personel(tc,parola,ad,soyad,bolumId,hemsireId,unvanId,randevuId) values(@tc,@parola,@ad,@soyad,@bolumId,@hemsireId,'1',@randevuId)", con);
            try
            {
                if (txt_tc.Text != null & txt_pass.Text != null & txt_ad.Text != null & txt_soyad.Text != null & txt_bolumıd.Text != null)
                {
                    com.Parameters.AddWithValue("tc", txt_tc.Text);
                    com.Parameters.AddWithValue("parola", txt_pass.Text);
                    com.Parameters.AddWithValue("ad", txt_ad.Text);
                    com.Parameters.AddWithValue("soyad", txt_soyad.Text);
                    com.Parameters.AddWithValue("bolumId", txt_bolumıd.Text);
                    com.Parameters.AddWithValue("hemsireId", txthemsıireıd.Text);
                    com.Parameters.AddWithValue("randevuId", txtrandevuıd.Text);
                }
                else
                {
                    MessageBox.Show("bu alanlar bos bırakılamaz.");
                }


                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    int satır = com.ExecuteNonQuery();
                    MessageBox.Show("+" + satır + " Doktor Kaydı basarıyla alındı:)");

                }
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
