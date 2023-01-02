using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spor_salonu
{
        internal class vt
    {
        public MySqlConnection Con;
        public vt()
        {

            Con = new MySqlConnection("server=localhost;database=spor_salonu; uid=root; password='';");


        }
        public void baglantiAc()
        {
            Con.Open();

        }
        public void baglantiKapa()
        {
            Con.Close();
        }
       
    }
}
       