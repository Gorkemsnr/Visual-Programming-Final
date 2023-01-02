using MySql.Data.MySqlClient;
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
    public partial class UyeleriGoruntule : Form
    {
        public UyeleriGoruntule()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MySqlConnection Con = new MySqlConnection("Server=localhost;Database=spor_salonu;Uid=root;Pwd='';");
        private void populate()
        {
            Con.Open();
            string query = "select * from membertbl";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyeSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void UyeleriGoruntule_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
        private void FilterByName()
        {
            Con.Open();
            string query = "select * from membertbl where MName='" + SearchMember.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            uyeSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
