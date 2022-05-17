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
    public partial class OgrenciBilgilerimSayfasi : Form
    {
        public Students student = new Students();
        public OgrenciBilgilerimSayfasi()
        {
            InitializeComponent();
        }
        MiaKayit miakayit = new MiaKayit();
        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            miakayit.label3.Text = "\n\nBilgilerini Değiştirmek İstiyorsan\n\nÖğretmenlerine Veya Görevli birine mail atabilirsin :)";
            miakayit.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            miakayit.Hide();
        }

        private void OgrenciBilgilerimSayfasi_Load(object sender, EventArgs e)
        {

        }
    }
}

