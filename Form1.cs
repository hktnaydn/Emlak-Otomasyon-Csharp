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

namespace emlakortomasyonu
{
   

    public partial class Form1 : Form
    {
        public static string musterino = null;
       
        public Form1()
        {
            InitializeComponent();
        }
        public static MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        public static MySqlConnection baglanti;
        private void Form1_Load(object sender, EventArgs e)
        {

            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "emlakdatabase";
            build.Password = "safranbolu78";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
     
        bool isThere;
        private void button1_Click(object sender, EventArgs e)
        {
            string musteri = textBox1.Text;
            string sifresi = password.Text;



            baglanti.Open();
            MySqlCommand command = new MySqlCommand("select * from uyeler", baglanti);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((musteri == reader["uyeno"].ToString().Trim()) && sifresi == reader["password"].ToString().Trim())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            baglanti.Close();
            if (isThere)
            {
                musterino = textBox1.Text;
                MessageBox.Show("Başarıyla giriş yaptınız", "EMLAK OTOMASYON");
                manageUsers panel = new manageUsers();
                panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız", "Program");
            }
        }

        private void showpasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(showpasswordCheckbox.Checked==true)
            {
                password.isPassword = false;
            }
            else {
                password.isPassword = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "Kullanıcı ID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı ID";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {

            if (password.Text == "Şifre")
            {
                password.Text = "";
                password.ForeColor = Color.White;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {

            if (password.Text == "")
            {
                password.Text = "Şifre";
                password.ForeColor = Color.White;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            kayit kayitt = new kayit();
            kayitt.Show();
            this.Hide();
        }
    }
}
