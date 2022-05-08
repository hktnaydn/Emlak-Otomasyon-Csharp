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
    public partial class UC_ilanlar : UserControl
    {
        public UC_ilanlar()
        {
            InitializeComponent();
        }
        public static int S_ilan_No{get; set;}

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            S_ilan_No = Convert.ToInt32(bunifuThinButton21.Tag);
        }
    }
}
