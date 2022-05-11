using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emlakortomasyonu
{
    public partial class UC_ilanlarim : UserControl
    {
        public UC_ilanlarim()
        {
            InitializeComponent();
        }
        public static int S_ilan_No { get; set; }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            S_ilan_No = Convert.ToInt32(bunifuImageButton1.Tag);
        }
    }
}
