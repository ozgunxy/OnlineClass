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
    public partial class OgrenciAnaMenu : Form
    {
        public OgrenciAnaMenu()
        {
            InitializeComponent();
        }
        public Students student = new Students();
        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            SınavOl sinavol = new SınavOl();
            sinavol.student = student;
            sinavol.Show();
            this.Hide();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciAnaMenu_Load(object sender, EventArgs e)
        {
            student.StudentId = (int)DataBase.getInstance().executeScalar(string.Format("SELECT studentId FROM Students WHERE studentUserName = '{0}' and studentPw = '{1}' ", student.studentUserName, student.studentPw));

        }

    

        private void bunifuTileButton4_Click_1(object sender, EventArgs e)
        {
            OgrenciBilgilerimSayfasi Ogrenci = new OgrenciBilgilerimSayfasi();
            Ogrenci.student = student;
            Ogrenci.Show();
            this.Hide();
        }
    }
}
