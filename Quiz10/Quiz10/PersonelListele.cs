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
    public partial class PersonelListele : Form
    {
        SqlCommand com;
        SqlConnection conn = new SqlConnection(@"SERVER=DESKTOP-EOKQ1OG\SQLEXPRESS;DATABASE=RandevuSistemiDB;Trusted_Connection=True;");
        public PersonelListele()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in comboBox1.Items)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    SqlCommand com = new SqlCommand("select ad,soyad from personel where unvanId=1", conn);
                    KomutCalıstır(com);
                   
                }
                else
                    if (comboBox1.SelectedIndex == 1)
                    {
                         com = new SqlCommand("select ad,soyad from personel where unvanId=2", conn);
                         KomutCalıstır(com);
                    }
                    else
                        if (comboBox1.SelectedIndex == 2)
                        {
                         com = new SqlCommand("select ad,soyad from personel where unvanId=3", conn);
                         KomutCalıstır(com);
                        }
                        else
                            if (comboBox1.SelectedIndex == 3)
                            {
                                com = new SqlCommand("select ad,soyad,unvanad from personel p join Unvan u on p.unvanId=u.unvanId", conn);
                              KomutCalıstır(com);
                            }

            }

        }
        private void KomutCalıstır(SqlCommand comm)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            conn.Close();
        }
    }
}
