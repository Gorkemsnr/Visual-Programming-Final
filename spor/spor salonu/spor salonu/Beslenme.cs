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
    public partial class Beslenme : Form
    {
        public Beslenme()
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

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=("Eğer 1-2 saat arası süren bir egzersiz programı yapacaksanız, örneğin futbol maçı, ağırlık kaldırma, güreşme vb. gibi, aşağıdaki besinlerden tercihinize göre birini tüketebilirsiniz. 1 büyük boy muz,1 porsiyon tatlı meyve,1 kase pişmiş pirinç pilavı,50 gram yulaf ezmesi,50 gram fıstık ezmesi. Bu besinleri:Egzersizden 30 - 60 dakika öncesinde,Bir miktar tuz ve su ile; veya bir pre workout supplementi ile tüketmenizi öneririz.");
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ("Spordan sonra ise karbonhidrat ve proteinli bir öğün faydalı olacaktır.Günün en büyük öğününü spordan sonraya saklamak mantıklı bir yaklaşım olabilir.Intermittent Fasting uyguluyorsanız, antrenman esnasında BCAA almanız faydalı olabilir. Antrenmandan sonra ise karbonhidrat ve proteinli bir öğün tüketmelisiniz.Onun dışında kalorilerinizi yeme döneminde istediğiniz öğün miktarında alabilirsiniz.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ("Piramitten öğrendiğimiz üzere, beslenme programı için supplementler en son endişelenmemiz gereken gıdalar. Çünkü bunların hemen hemen hepsini gıdalardan zaten alabiliriz.Kimileri tamamıyla önemsiz, kimileri yerine göre önemli hatta elzem oluyor.Detaylar için Ağırsağlam’da tıpkı bu rehber gibi bir supplement rehberimiz var.Tamamı efsanelerin reddedilip, bilimsel gerçeklerin öncülüğünde incelendi.Bu rehberi incelemeden supplement almayın, pişman olabilirsiniz!");
        }
    }
}
