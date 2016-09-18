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
    public partial class RandevuAl : Form
    {
        string UyeBolumAd;
        string UyeDoktorAdSoyad;
        string UyeRandevusaat;
        SqlConnection conn = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");
        SqlCommand com;
        public string hastaid = UyeGirisi.uyeid;
        public DateTime randevuId;
        public RandevuAl()
        {
            InitializeComponent();
        }


        private void RandevuAl_Load(object sender, EventArgs e)
        {

            ComboDoldur();
        }
        private void ComboDoldur()
        {

            randevuId = Convert.ToDateTime(dateTimePicker1.Text);
            SqlDataAdapter da = new SqlDataAdapter("select bolumId,ad from bolum", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ad";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            UyeBolumAd = comboBox1.SelectedItem.ToString();

            SqlDataAdapter da = new SqlDataAdapter("select tc,ad+' '+soyad as adsoyad from personel where unvanId=1 and bolumId=@bid", conn);
            comboBox1.ValueMember = "bolumId";
            da.SelectCommand.Parameters.AddWithValue("bid", comboBox1.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "adsoyad";
            comboBox2.ValueMember = "tc";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyeDoktorAdSoyad = comboBox2.SelectedItem.ToString();

            SqlDataAdapter da = new SqlDataAdapter("select id,saat from saat", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "saat";
            comboBox3.ValueMember = "id";

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UyeRandevusaat = comboBox3.SelectedItem.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("insert into randevu(hastaId,doktorId,durum,saatId,rtarih) values(@hastaId,@doktorId,1,@saatId,@rtarih)", conn);
            comm.Parameters.AddWithValue("hastaId", UyeGirisi.uyeid);
            comm.Parameters.AddWithValue("doktorId", comboBox2.SelectedValue);
            comm.Parameters.AddWithValue("saatId", comboBox3.SelectedValue);
            comm.Parameters.AddWithValue("rtarih", randevuId);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                comm.ExecuteNonQuery();

            }
            conn.Close();
            MessageBox.Show("randevu eklendi..:)");
        }

    }
}