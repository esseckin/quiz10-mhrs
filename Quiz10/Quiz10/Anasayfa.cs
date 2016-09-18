using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz10
{
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {
            InitializeComponent();
        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UyeGirisi.yetki == 0)
            {
                PersonelListele form2 = new PersonelListele();
                form2.MdiParent = this;
                form2.WindowState = FormWindowState.Maximized;
                form2.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();
            }

        }

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UyeGirisi.yetki == 0)
            {
                UyeKayıt form3 = new UyeKayıt();
                form3.MdiParent = this;
                form3.WindowState = FormWindowState.Maximized;
                form3.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();
            }

        }

        private void uyeGirisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeGirisi form4 = new UyeGirisi();
            form4.MdiParent = this;
            form4.WindowState = FormWindowState.Maximized;
            form4.Show();
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UyeGirisi.yetki == 0)
            {
                RandevuAl form5 = new RandevuAl();
                form5.MdiParent = this;
                form5.WindowState = FormWindowState.Maximized;
                form5.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();
            }
        }

        private void randevuGecmisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UyeGirisi.yetki == 0)
            {
                RandevuGecmisi form6 = new RandevuGecmisi();
                form6.MdiParent = this;
                form6.WindowState = FormWindowState.Maximized;
                form6.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();

            }
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (UyeGirisi.yetki == 1)
            {
                DoktorEkle form8 = new DoktorEkle();
                form8.MdiParent = this;
                form8.WindowState = FormWindowState.Maximized;
                form8.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();

            }
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UyeGirisi.yetki == 0)
            {
                UyeGirisi form4 = new UyeGirisi();
                form4.MdiParent = this;
                form4.WindowState = FormWindowState.Maximized;
                form4.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();
            }

        }

        private void hemsireToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (UyeGirisi.yetki == 1)
            {
                HemsireEkle form9 = new HemsireEkle();
                form9.MdiParent = this;
                form9.WindowState = FormWindowState.Maximized;
                form9.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();

            }

        }

        private void hizmetliToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (UyeGirisi.yetki == 1)
            {
                HizmetliEkle form10 = new HizmetliEkle();
                form10.MdiParent = this;
                form10.WindowState = FormWindowState.Maximized;
                form10.Show();
            }
            else
            {
                yetkiYok form7 = new yetkiYok();
                form7.MdiParent = this;
                form7.WindowState = FormWindowState.Maximized;
                form7.Show();

            }
        }

        private void cıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Cıkıs Yaptınız..");
            UyeGirisi.yetki = 2;
            UyeGirisi form4 = new UyeGirisi();
            form4.MdiParent = this;
            form4.WindowState = FormWindowState.Maximized;
            form4.Show();
        }
    }
}
