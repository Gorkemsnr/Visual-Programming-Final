using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace spor_salonu
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        MySqlConnection Con = new MySqlConnection("Server=localhost;Database=spor_salonu;Uid=root;Pwd='';");
        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {

                string query = "INSERT INTO  membertbl (MName, MPhone, Mgen, MAge, MAmount, MTiming) values" +
                    "('" + NameTb.Text + "','" + PhoneTb.Text + "','" + GenderCb.SelectedItem.ToString()
                    + "','" + AgeTb.Text + "','" + AmountTb.Text + "','" + TimingCb.SelectedItem.ToString() + "')";


                try
                {
                    Con.Open();

                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla eklendi");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AmountTb.Text = "";
                AgeTb.Text = "";
                NameTb.Text = "";
                PhoneTb.Text = "";
                GenderCb.Text = "";
                TimingCb.Text = "";
            }

        }                        

               
      

        private void button2_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            TimingCb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
