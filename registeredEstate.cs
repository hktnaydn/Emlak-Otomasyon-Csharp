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
using System.IO;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace emlakortomasyonu
{
    public partial class registeredEstate : Form
    {

        MySqlConnection connection = Form1.baglanti;

        public registeredEstate()
        {
            InitializeComponent();
            Fillcombo();
        }

        Resimleme Resimleme = new Resimleme();
        public void Baslangic()
        {
            if(comboBox3.SelectedIndex==-1)
            {
                MessageBox.Show("Lütfen seçim yapınız");
            }
            else
            {
                string ilcead = comboBox3.Text;
                panel_ilan.Controls.Clear();
                string constring = "datasource=localhost;port=3306;username=root;password=safranbolu78";

                string Query = "select * from emlakdatabase.ilandakievler where ilcead='" + ilcead + "' AND status='" + 0 + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);

                // Şehirleri Combobox a çekme
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);


                // City


                MySqlDataReader MyReader;
                try
                {
                    conDataBase.Open();
                    MyReader = cmdDataBase.ExecuteReader();
                    while (MyReader.Read())
                    {
                        UC_ilanlar uc = new UC_ilanlar();
                        String sName = MyReader.GetString("title");
                        String sdurum = MyReader.GetString("durum");
                        String sfiyat = MyReader.GetString("fiyat");
                        String sevturu = MyReader.GetString("evturu");
                        String sevno = MyReader.GetString("evno");
                        uc.lbl_baslik.Text = sName;
                        uc.pictureBox1.ImageLocation = Application.StartupPath + @"\Image\" + Path.GetFileName(MyReader["resimbir"].ToString());
                        uc.lbl_durum.Text = sdurum;
                        uc.lbl_konum.Text = sevturu;
                        uc.lbl_fiyat.Text = sfiyat;
                        uc.bunifuThinButton21.Tag = sevno;
                        uc.bunifuThinButton21.Click += T1_Click;
                        uc.Dock = DockStyle.Top;
                        panel_ilan.Controls.Add(uc);

                    }

                }
                catch (Exception excity)
                {
                    MessageBox.Show(excity.Message);
                }
                conDataBase.Close();


            }
          
        }
        public void T1_Click(object sender, EventArgs e)
        {
            int index = UC_ilanlar.S_ilan_No;
            string ilanisim = manageUsers.uyeisim;
            string ilantelno = manageUsers.uyetelno;
            ımageSlider1.Images.Clear();
            string constring = "datasource=localhost;port=3306;username=root;password=safranbolu78";
            string Query = "select * from emlakdatabase.ilandakievler where evno='" + index + "'"; 
            MySqlConnection conDataBase = new MySqlConnection(constring);

            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);



            MySqlDataReader MyReader;
           
            try
            {
                conDataBase.Open();
                MyReader = cmdDataBase.ExecuteReader();
                
                while (MyReader.Read())
                {
                    String skat = MyReader.GetString("kat");
                    String smetrekare = MyReader.GetString("metrekare");
                    String sodasayi = MyReader.GetString("odasayi");
                    String saciklama = MyReader.GetString("acıklama");
                    String adres = MyReader.GetString("adres");
                    lbl_kat.Text = skat;
                    ımageSlider1.Images.Add(Image.FromFile(Application.StartupPath + @"\Image\" + Path.GetFileName(MyReader["resimbir"].ToString())));
                    ımageSlider1.Images.Add(Image.FromFile(Application.StartupPath + @"\Image\" + Path.GetFileName(MyReader["resimiki"].ToString())));
                    ımageSlider1.Images.Add(Image.FromFile(Application.StartupPath + @"\Image\" + Path.GetFileName(MyReader["resimuc"].ToString())));


                    //     pictureBox1.ImageLocation = Application.StartupPath + @"\Image\" + Path.GetFileName(MyReader["resimbir"].ToString());
                    lbl_alan.Text = smetrekare;
                    lbl_odasayi.Text = sodasayi;
                    lbl_aciklama.Text = saciklama;
                    lbl_ilansahibi.Text = ilanisim;
                    lbl_telno.Text = ilantelno;
                    lbl_adres.Text = adres;
                    
                   
                 

                }

            }
            catch (Exception excity)
            {
                MessageBox.Show(excity.Message);
            }
            conDataBase.Close();
        }
        void Fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=safranbolu78";
  
            string QueryCity = "select * from emlakdatabase.sehirler;";
            int sNameCityNo = 0;
            MySqlConnection conDataBase = new MySqlConnection(constring);

            // Şehirleri Combobox a çekme
            MySqlCommand cmdDataBaseCity = new MySqlCommand(QueryCity, conDataBase);

         
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            manageUsers lobi = new manageUsers();
            lobi.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int plaka = 0;
            comboBox3.Items.Clear();
            connection.Open();
            MySqlCommand secilensehirno = new MySqlCommand("select sehirno from emlakdatabase.sehirler where sehirad='" + comboBox2.Text + "'", connection);
            MySqlDataReader reader = secilensehirno.ExecuteReader();
            while (reader.Read())
            {

                string sehirno = reader["sehirno"].ToString();
                plaka = int.Parse(sehirno);
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

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Baslangic();
        }

        private void registeredEstate_Load(object sender, EventArgs e)
        {
          
        }
    }
}
