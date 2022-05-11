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
    public partial class ilanlarim : Form
    {
       
        MySqlConnection connection = Form1.baglanti;
        public ilanlarim()
        {
            InitializeComponent();
            Baslangic();
        }
        public void Baslangic()
        {
                panel_ilanlarim.Controls.Clear();
                string constring = "datasource=localhost;port=3306;username=root;password=safranbolu78";

                string Query = "select * from emlakdatabase.ilandakievler where uyeno='" + Form1.musterino + "' AND status='" + 0 + "'";
                MySqlConnection conDataBase = new MySqlConnection(constring);

                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);

                MySqlDataReader MyReader;
                try
                {
                    conDataBase.Open();
                    MyReader = cmdDataBase.ExecuteReader();
                    while (MyReader.Read())
                    {
                        UC_ilanlarim uc = new UC_ilanlarim();
                        String sName = MyReader.GetString("title");
                        String sdurum = MyReader.GetString("durum");
                        String sfiyat = MyReader.GetString("fiyat");
                        String sevturu = MyReader.GetString("evturu");
                        String sevno = MyReader.GetString("evno");
                        String skat = MyReader.GetString("kat");
                        String skonum = MyReader.GetString("ilcead");
                        String sodasayi = MyReader.GetString("odasayi");
                        String saciklama = MyReader.GetString("acıklama");
                        String adres = MyReader.GetString("adres");
                        uc.lbl_baslik.Text = sName;
                        uc.pictureBox2.ImageLocation = Application.StartupPath + @"\Image\" + Path.GetFileName(MyReader["resimbir"].ToString());
                        uc.lbl_durum.Text = sdurum;
                        uc.lbl_evturu.Text = sevturu;
                        uc.lbl_konum.Text = sfiyat;
                        uc.lbl_konum.Text = skonum;
                        uc.lbl_oda.Text = sodasayi;
                        uc.lbl_kat.Text = skat;
                        uc.lbl_aciklama.Text = saciklama;
                        uc.lbl_adres.Text = adres;
                        uc.bunifuImageButton1.Tag = sevno;
                        uc.bunifuImageButton1.Click += T1_Click;
                        uc.Dock = DockStyle.Top;
                        panel_ilanlarim.Controls.Add(uc);

                    }

                }
                catch (Exception excity)
                {
                    MessageBox.Show(excity.Message);
                }
                conDataBase.Close();


            

        }
        public void T1_Click(object sender, EventArgs e)
        {
            connection.Open();
            int index = UC_ilanlarim.S_ilan_No;
            MySqlCommand satildi = new MySqlCommand("update emlakdatabase.ilandakievler set status='" + 1 + "'where evno='" + index + "'", connection);
            satildi.ExecuteNonQuery();
            MessageBox.Show("Ev Satıldı");
            connection.Close();
            Baslangic();

        }
            private void button2_Click(object sender, EventArgs e)
        {
            manageUsers lobi = new manageUsers();
            lobi.Show();
            this.Close();
        }
    }
}
