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
        public manageUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

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
    }
}
