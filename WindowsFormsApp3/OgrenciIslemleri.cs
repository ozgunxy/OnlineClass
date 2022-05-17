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
        public void selectStudents() // Öğrencileri Listeleme Fonksiyonu
        {
            bunifuCustomDataGrid1.DataSource = DataBase.getInstance().executeDataTable("Select * from Students");
        }
        public void insertStudents() // Öğrencileri Ekleme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("INSERT INTO Students (studentUserName,studentName,studentSurname,studentBranch,studentPw,studentMail,responsibleTeacherId,studentRole,studentBirthday) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", bunifuMaterialTextbox9.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox10.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox8.Text, bunifuMaterialTextbox6.Text, bunifuMaterialTextbox5.Text, bunifuMaterialTextbox4.Text, bunifuDatepicker1.Value));
        }
        public void deleteStudents() // Öğrencileri Silme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("Delete from Students Where studentId={0}", bunifuMaterialTextbox1.Text));
        }
        public void updateStudents() // Öğrencileri Güncelleme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("Update Students studentUserName={0},studentName={1},studentSurname={2},studentBranch={3},studentPw={4},studentMail={5},responsibleTeacherId={6},studentRole={7},studentBirthday={8} set Where studentId={9}", bunifuMaterialTextbox9.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox10.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox8.Text, bunifuMaterialTextbox6.Text, bunifuMaterialTextbox5.Text, bunifuMaterialTextbox4.Text, bunifuDatepicker1.Value,bunifuMaterialTextbox1.Text));
        }
        public void clearAllTextbox()
        {

            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox5.Text = "";
            bunifuMaterialTextbox6.Text = "";
            bunifuMaterialTextbox8.Text = "";
            bunifuMaterialTextbox9.Text = "";
            bunifuMaterialTextbox10.Text = "";   
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            selectStudents();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            insertStudents();      
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            deleteStudents();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            updateStudents();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            clearAllTextbox();
        }
    }
}
