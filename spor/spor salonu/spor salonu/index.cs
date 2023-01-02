using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace spor_salonu
{
    public partial class index : Form
    {
        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public index()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hakkımızda hak = new Hakkımızda();
            hak.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Blog blog = new Blog();
            blog.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Galeri gal = new Galeri();
            gal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iletisim ilet = new iletisim();
            ilet.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Uyelikfiyat fiyat = new Uyelikfiyat();
            fiyat.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(hava_durumu_link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");

            foreach (XmlNode node in nodes)
            {
                string ili = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string maks_sicaklik = node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ili;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = maks_sicaklik;
                dataGridView1.Rows.Add(row);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Beslenme bes = new Beslenme();
            bes.Show();
            this.Hide();
        }
    }
}
