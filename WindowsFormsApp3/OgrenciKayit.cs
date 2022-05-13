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
    public partial class OgrenciKayit : Form
    {
        public OgrenciKayit()
        {
            InitializeComponent();
            
        }
        MiaKayit mk = new MiaKayit();
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
           
            mk.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            mk.Hide();
        }
    }
}
