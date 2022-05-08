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

namespace emlakortomasyonu
{
    
    public partial class manageUsers : Form
    {
        MySqlConnection connection = Form1.baglanti;
        public manageUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public static string uyetelno = null;
        public static string uyeisim = null;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            kayitemlak kayitemlak = new kayitemlak();
            kayitemlak.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            registeredEstate estate = new registeredEstate();
            estate.Show();
            this.Hide();
        }

        private void manageUsers_Load(object sender, EventArgs e)
        {
            int musterino = Int16.Parse(Form1.musterino);
            connection.Open();
            MySqlCommand command = new MySqlCommand("select * from emlakdatabase.uyeler where uyeno='" + musterino + "'", connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                uyetelno = reader["cepno"].ToString();
                uyeisim = reader["isim"].ToString();
            }
            connection.Close();
        }
    }
}
