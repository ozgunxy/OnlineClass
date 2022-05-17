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
    public partial class SınavHazırlamaSayfasi : Form
    {
        public SınavHazırlamaSayfasi()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OgretmenAnaMenu ogretmenAnaMenu = new OgretmenAnaMenu();
            ogretmenAnaMenu.Show();
            this.Hide();
        }
    }
}
