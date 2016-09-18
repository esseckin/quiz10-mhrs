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
    public partial class UyeKayıt : Form
    {
        SqlCommand com;
        SqlConnection conn = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");
        public UyeKayıt()
        {
            InitializeComponent();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            byte cinsiyet=0;
            try
            {
                cinsiyet = radio_bayan.Checked == true ? (byte)1 : (byte)0;

                SqlCommand com = new SqlCommand("insert into hasta(tc,ad,soyad,parola,telNo,mail,dTar,cinsiyet) values('" + txt_tc.Text + "','" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_pass.Text + "','" + txt_tel.Text + "','" + txt_mail.Text + "','" +Convert.ToDateTime(dateTimePicker1.Text) + "','" +cinsiyet+ "')", conn);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                  int satır= com.ExecuteNonQuery();
                    MessageBox.Show("+"+satır+" Kaydınız basarıyla alındı:)");
                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
