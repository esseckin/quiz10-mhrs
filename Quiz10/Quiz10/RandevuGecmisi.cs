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
    public partial class RandevuGecmisi : Form
    {
        SqlConnection conn = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");

        public RandevuGecmisi()
        {
            InitializeComponent();
        }

        private void RandevuGecmisi_Load(object sender, EventArgs e)
        {
            comboDol();
        }

        private void comboDol()
        {
            SqlDataAdapter da = new SqlDataAdapter("select randevuId from randevu where hastaid=@hastaid",conn);
             da.SelectCommand.Parameters.AddWithValue("hastaid",UyeGirisi.uyeid);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_randevu.DataSource = dt;
            cmb_randevu.DisplayMember = "randevuId";
            cmb_randevu.ValueMember = "randevuId";
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from randevu where hastaid=@hastaid and randevuId=@randevuid", conn);
            da.SelectCommand.Parameters.AddWithValue("hastaid", UyeGirisi.uyeid);
            da.SelectCommand.Parameters.AddWithValue("randevuid",cmb_randevu.SelectedValue);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgw_randevu.DataSource =dt;
         
        }
    }
}
