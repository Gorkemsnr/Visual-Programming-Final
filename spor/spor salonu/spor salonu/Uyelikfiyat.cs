using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spor_salonu
{
    public partial class Uyelikfiyat : Form
    {
        public Uyelikfiyat()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index ind = new index();
            ind.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Aylık ücret=400");       
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("3 Aylık ücret=1000");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("6 Aylık ücret=1800");
        }
    }
}
