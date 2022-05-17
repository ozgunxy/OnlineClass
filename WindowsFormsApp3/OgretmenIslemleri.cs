using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp3
{
    public partial class OgretmenIslemleri : Form
    {
        public OgretmenIslemleri()
        {
            InitializeComponent();
        }

        public void selectTeachers() // Soruları Listeleme Fonksiyonu
        {
            bunifuCustomDataGrid1.DataSource = DataBase.getInstance().executeDataTable("Select * from Teachers");
        }
        public void updateTeachers() // Soruları Güncelleme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("Update Teachers Set teacherName='{0}',teacherSurname={1},teacherBranch={2},teacherPw={3},teacherMail={4},teacherPhoneNumber={5},teacherLessonBranch={6},teacherBirthday={7},teacherUserName={8} where teacherId={9}", bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox6.Text, bunifuMaterialTextbox4.Text, bunifuMaterialTextbox9.Text, bunifuMaterialTextbox10.Text, bunifuMaterialTextbox8.Text,bunifuDatepicker1.Value, bunifuMaterialTextbox5.Text));
        }
        public void deleteTeachers() // Soruları Silme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("Delete from Teachers Where teacherId={0}", bunifuMaterialTextbox1.Text));
        }
        public void insertTeachers() // Soruları Ekleme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("INSERT INTO Teachers (teacherName,teacherSurname,teacherBranch,teacherPw,teacherMail,teacherPhoneNumber,teacherLessonBranch,teacherBirthday,teacherUserName) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", bunifuMaterialTextbox2.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox6.Text, bunifuMaterialTextbox4.Text, bunifuMaterialTextbox9.Text, bunifuMaterialTextbox10.Text, bunifuMaterialTextbox8.Text, bunifuDatepicker1.Value, bunifuMaterialTextbox5.Text));
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            selectTeachers();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            insertTeachers();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            updateTeachers();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            deleteTeachers();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
