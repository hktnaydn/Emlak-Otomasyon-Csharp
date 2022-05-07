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
    public partial class kayitemlak : Form
    {
        public kayitemlak()
        {
            InitializeComponent();
            Fillcombo();
        }
        MySqlConnection connection = Form1.baglanti;
        private void kayitemlak_Load(object sender, EventArgs e)
        {
        }
        void Fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=safranbolu78";
            string QueryEvtype = "select * from emlakdatabase.evturleri;";
            string QueryCity = "select * from emlakdatabase.sehirler;";
            int sNameCityNo = 0;
            MySqlConnection conDataBase = new MySqlConnection(constring);

            // Ev türlerini Combobox a çekme
            MySqlCommand cmdDataBase = new MySqlCommand(QueryEvtype, conDataBase);

            // Şehirleri Combobox a çekme
            MySqlCommand cmdDataBaseCity = new MySqlCommand(QueryCity, conDataBase);

            MySqlDataReader MyReader;
            try
            {
                conDataBase.Open();
                MyReader = cmdDataBase.ExecuteReader();
                while(MyReader.Read())
                {
                    String sName = MyReader.GetString("evturu");
                    comboBox1.Items.Add(sName);
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
            // City


            MySqlDataReader MyReaderCity;
            try
            {
                conDataBase.Open();
                MyReaderCity = cmdDataBaseCity.ExecuteReader();
                while (MyReaderCity.Read())
                {
                    String sNameCity = MyReaderCity.GetString("sehirad");
                    sNameCityNo = MyReaderCity.GetInt16("sehirno");
                  
                    comboBox2.Items.Add(sNameCity);
                    
                }

            }
            catch (Exception excity)
            {
                MessageBox.Show(excity.Message);
            }
            conDataBase.Close();

        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageUsers lobi = new manageUsers();
            lobi.Show();
            this.Close();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Kat Numarası")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.ForeColor = Color.White;
            }
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Kat Numarası";
                bunifuMaterialTextbox1.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "Ev Toplam Alan")
            {
                bunifuMaterialTextbox2.Text = "";
                bunifuMaterialTextbox2.ForeColor = Color.White;
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "Ev Toplam Alan";
                bunifuMaterialTextbox2.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "Ev Oda Sayısı")
            {
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox3.ForeColor = Color.White;
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.Text = "Ev Oda Sayısı";
                bunifuMaterialTextbox3.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox5_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text == "Fiyat")
            {
                bunifuMaterialTextbox5.Text = "";
                bunifuMaterialTextbox5.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox5_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox5.Text == "")
            {
                bunifuMaterialTextbox5.Text = "Fiyat";
                bunifuMaterialTextbox5.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "ADRES")
            {
                bunifuMaterialTextbox4.Text = "";
                bunifuMaterialTextbox4.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "ADRES";
                bunifuMaterialTextbox4.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox6_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox6.Text == "EK AÇIKLAMALAR")
            {
                bunifuMaterialTextbox6.Text = "";
                bunifuMaterialTextbox6.ForeColor = Color.Red;
            }
        }

        private void bunifuMaterialTextbox6_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox6.Text == "")
            {
                bunifuMaterialTextbox6.Text = "EK AÇIKLAMALAR";
                bunifuMaterialTextbox6.ForeColor = Color.Red;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int plaka=0;
            comboBox3.Items.Clear();
            connection.Open();
            MySqlCommand secilensehirno = new MySqlCommand("select sehirno from emlakdatabase.sehirler where sehirad='" + comboBox2.Text+"'", connection);
            MySqlDataReader reader = secilensehirno.ExecuteReader();
            while (reader.Read())
            {
                
                string sehirno = reader["sehirno"].ToString();
                plaka = int.Parse(sehirno);
                MessageBox.Show("Tebrikler hesabınız oluşturuldu! Müşteri numaranız : " + plaka.ToString(), "DÖVİZ AL-SAT");
            }
            connection.Close();
            connection.Open();
            MySqlCommand sehirnob = new MySqlCommand("select * from emlakdatabase.ilceler where sehirno='" + plaka + "'", connection);
            MySqlDataReader readerr = sehirnob.ExecuteReader();
            while (readerr.Read())
            {
                comboBox3.Items.Add(readerr["ilcead"].ToString());
            }



            connection.Close();
        }
    }
}
