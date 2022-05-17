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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DimGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.DarkGray;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox2.Text == "")
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun");
                return;
            }
            if (DataBase.getInstance().Login(bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text, "Student"))
            {
                Students student = new Students();
                student.studentUserName = bunifuMaterialTextbox1.Text;
                student.studentPw = bunifuMaterialTextbox2.Text;
                OgrenciAnaMenu Menu = new OgrenciAnaMenu();
                Menu.student = student;
                this.Hide();
                Menu.Show();
                MessageBox.Show("HosGeldiniz");
            }
            else
            {
                MessageBox.Show("Basarisiz Giris");
                return;
            }
        }
    }
}
