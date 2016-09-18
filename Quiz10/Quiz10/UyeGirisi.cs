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
    public partial class UyeGirisi : Form
    {
       public static string uyeid;
        string ad, soyad;
        string admin = "1";
        string adminPass = "1";
        
       public static int yetki;
        SqlCommand com;
        SqlConnection conn = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");
        public UyeGirisi()
        {
            InitializeComponent();
        }

        private void UyeGirisi_Load(object sender, EventArgs e)
        {
            this.Location = new Point(500,150);
        }

        private void txt_uyeGiris_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = txt_kullanıcıAd.Text;
            string pass = txt_pass.Text;
            SqlDataReader rd = null;
            try
            {
                SqlCommand com = new SqlCommand("select tc from hasta where tc=@tc ", conn);
                com.Parameters.AddWithValue("@tc", kullanıcıAdı);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    int varMı = Convert.ToInt32(com.ExecuteScalar());

                    if (varMı > 0)
                    {
                        com = new SqlCommand("select parola,ad,soyad from hasta where tc=@tc ", conn);
                        com.Parameters.AddWithValue("@tc", kullanıcıAdı);
                        rd = com.ExecuteReader();
                        if (rd.HasRows)
                        {
                            while (rd.Read())
                            {
                                bool sonuc = rd.GetString(0).Equals(txt_pass.Text);
                                ad = rd.GetString(1);
                                soyad = rd.GetString(2);
                                if (sonuc)
                                {

                                    yetki = 0;
                                    com = new SqlCommand("select parola from hasta where tc=@tc", conn);
                                    com.Parameters.AddWithValue("@tc", kullanıcıAdı);
                                    uyeid = kullanıcıAdı;
                                    MessageBox.Show("Hosgeldin " + ad +" "+ soyad + " basarıyla giriş yaptın:)");
                                }
                                else
                                {
                                    MessageBox.Show("hatalı sifre");
                                }
                            }

                        }

                    }
                    else
                    {
                        MessageBox.Show("boyle bir kullanıcı kayıtlı degil");
                    }
                    if (kullanıcıAdı == admin && pass == adminPass)
                    {
                        yetki = 1;
                        MessageBox.Show("admin olarak giriş yaptınız..");
                    }
                }
                rd.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
