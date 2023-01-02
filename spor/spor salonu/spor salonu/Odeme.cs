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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        MySqlConnection Con = new MySqlConnection("Server=localhost;Database=spor_salonu;Uid=root;Pwd='';");
        private void FillName()
        {
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("select Mname from membertbl", Con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mname", typeof(string));
            dt.Load(rdr);
            NameCb.ValueMember = "Mname";
            NameCb.DataSource = dt;
            Con.Close();
        }
        private void FilterByName()
        {
            Con.Open();
            string query = "select * from odeme where PMember='"+SearchName.Text+"'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeSDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from odeme";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeSDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //NameTb.Text = "";
            AmountTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (NameCb.Text=="" || AmountTb.Text=="" )
            {
                MessageBox.Show("Eksik Bilgi Giriş");
            }
            else
            {
                string payperiode = Periode.Value.Month.ToString()+Periode.Value.Year.ToString();
                Con.Open();
                MySqlDataAdapter sda=new MySqlDataAdapter("select count(*)from odeme where PMember='"+NameCb.SelectedValue.ToString()+"' and PMonth='"+payperiode+"'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    MessageBox.Show("Zaten Bu Ayı Ödediniz");
                }
                else
                {
                    string query="insert into odeme (PMonth, PMember, PAmount) values('"+payperiode+"','"+NameCb.SelectedValue.ToString()+"',"+AmountTb.Text+")";
                    MySqlCommand cmd = new MySqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Miktar Başarıyla Ödendi");
                }
                Con.Close();
                populate();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilterByName();
            SearchName.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
