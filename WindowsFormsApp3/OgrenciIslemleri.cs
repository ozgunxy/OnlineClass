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
    public partial class OgrenciIslemleri : Form
    {
        public OgrenciIslemleri()
        {
            InitializeComponent();
        }
        MiaKayit mk = new MiaKayit();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
            mk.label3.Text = "Burada öğrenci ekleme çıkarma silme güncelleme\n\nİşlemleri yapabilirsiniz öğrencileri detaylı arama menüsünden\n\narayabilirsiniz Öğrencinin id'sine göre işlem yapmak her zaman\n\n dava avantajlıdır";
            mk.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            mk.Hide();
        }
    }
}
