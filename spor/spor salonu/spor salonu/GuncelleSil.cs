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
    public partial class GuncelleSil : Form
    {
        public GuncelleSil()
        {
            InitializeComponent();
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
        private void GuncelleSil_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key=0;
        private void uyeSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(uyeSDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = uyeSDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = uyeSDGV.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = uyeSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text= uyeSDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text= uyeSDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text= uyeSDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AgeTb.Text = "";
            PhoneTb.Text = "";
            TimingCb.Text="";
            AmountTb.Text = "";
            GenderCb.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key==0)
            {
                MessageBox.Show("Silmek İçin Üye Seçiniz");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from membertbl where MId=" + key + ";";
                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text ==""|| PhoneTb.Text =="" || AgeTb.Text =="" || AmountTb.Text =="" || GenderCb.Text =="" || TimingCb.Text=="" )
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update membertbl set MName='"+NameTb.Text+"', MPhone='"+PhoneTb.Text+"',MGen='"+GenderCb.Text+"',MAge="+AgeTb.Text+",MAmount="+AmountTb.Text+",MTiming='"+TimingCb.Text+"'where MId="+key+";";

                    MySqlCommand cmd = new MySqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla Güncellendi");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
