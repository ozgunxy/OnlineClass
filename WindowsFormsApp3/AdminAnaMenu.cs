using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AdminAnaMenu : Form
    {
        public AdminAnaMenu()
        {
            InitializeComponent();
        }
        OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
        OgretmenIslemleri OgretmenIslemleri = new OgretmenIslemleri();
        SoruIslemleri soruIslemleri= new SoruIslemleri();
        SınavHazırlamaSayfasi sinavhazirlamasayfasi = new SınavHazırlamaSayfasi();
        
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            sinavhazirlamasayfasi.Show();
            this.Hide();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            ogrenciIslemleri.Show();
            this.Hide();
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            OgretmenIslemleri.Show();
            this.Hide();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            soruIslemleri.Show();
            this.Hide();
        }
    }
}
