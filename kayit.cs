using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Globalization;

namespace emlakortomasyonu
{
    public partial class kayit : Form
    {

        static public string adsoyad { get; set; }
        static public string cepno { get; set; }
        static public string il { get; set; }

        static public string password { get; set; }


        MySqlConnection connection = Form1.baglanti;
 
        public kayit()
        {
            InitializeComponent();
       
        }

        private void kullanıcıidTextbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void showpasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordCheckbox.Checked == true)
            {
                passtextb.isPassword = false;
            }
            else
            {
                passtextb.isPassword = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            adsoyad = adtextb.Text;
            adsoyad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(adsoyad);
            il = "6";
            cepno = textBox2.Text;
            password = passtextb.Text;

            if (cepno != "" && adsoyad!="" && password!="" && il!="0" && adsoyad != "İsim" && password != "Şifre" && cepno != "Cep No")
            {

                connection.Open();
                MySqlCommand command = new MySqlCommand("Insert into uyeler (isim,cepno,sehirno,password) values ('" + kayit.adsoyad + "','" + kayit.cepno + "','" + kayit.il + "','" + kayit.password + "')", connection);
                command.ExecuteNonQuery();


                MySqlCommand uyenokomut = new MySqlCommand("select max(uyeno) from uyeler", connection);
                MessageBox.Show("Tebrikler hesabınız oluşturuldu! Üye numaranız : " + uyenokomut.ExecuteScalar().ToString(), "EMLAKOTOMASYON");
                connection.Close();
                Form1 giris = new Form1();
                giris.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Alanları doğru şekilde doldurunuz");
            }


            }

        private void adtextb_Enter(object sender, EventArgs e)
        {
            if (adtextb.Text == "İsim")
            {
                adtextb.Text = "";
                adtextb.ForeColor = Color.White;
            }
        }

        private void adtextb_Leave(object sender, EventArgs e)
        {
            if (adtextb.Text == "")
            {
                adtextb.Text = "İsim";
                adtextb.ForeColor = Color.White;
            }
        }

        private void passtextb_Enter(object sender, EventArgs e)
        {
            if (passtextb.Text == "Şifre")
            {
                passtextb.Text = "";
                passtextb.ForeColor = Color.White;
            }
        }

        private void passtextb_Leave(object sender, EventArgs e)
        {
            if (passtextb.Text == "")
            {
                passtextb.Text = "Şifre";
                passtextb.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Cep No")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Cep No";
                textBox2.ForeColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Close();
        }

        private void textBox2_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "Cep No")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Cep No";
                textBox2.ForeColor = Color.White;
            }
        }
    }
    }

