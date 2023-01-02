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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=spor_salonu;Uid=root;Pwd='';");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text=="" || PasswordTb.Text=="")
            {
                MessageBox.Show("Eksik bilgi Girişi");
            }
            else if (UidTb.Text=="Admin" && PasswordTb.Text=="Admin")
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                
            }
            else
            {
                MessageBox.Show("Yanlış Id ve ya Şifre");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PasswordTb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
