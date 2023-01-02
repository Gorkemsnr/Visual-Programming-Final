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
    public partial class iletisim : Form
    {
        public iletisim()
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
    }
}
