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
    public partial class SoruIslemleri : Form
    {
        public SoruIslemleri()
        {
            InitializeComponent();
        }
        public void selectQuestions() // Soruları Listeleme Fonksiyonu
        {
            bunifuCustomDataGrid1.DataSource = DataBase.getInstance().executeDataTable("Select * from Questions");
        }
        public void updateQuestions() // Soruları Güncelleme Fonksiyonu
        {
        DataBase.getInstance().executeNonQuery(string.Format("Update Questions Set questionText={0},questionVote1={1},questionVote2={2},questionVote3={3},questionVote4={4},questionTrueVote={5},questionDifficultyLevel={6},subjectId={7},lessonId={8},questionPicture={9},questionSolution={10} Where questionId={11}", bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox4.Text, bunifuMaterialTextbox5.Text, comboBox1.Text, comboBox4.Text, comboBox3.Text, comboBox2.Text, bunifuMaterialTextbox7.Text, textBox1.Text,bunifuMaterialTextbox6.Text));
        }
        public void deleteQuestions() // Soruları Silme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("Delete from Questions Where questionId={0}", bunifuMaterialTextbox6.Text));
        }
        public void insertQuestions() // Soruları Ekleme Fonksiyonu
        {
            DataBase.getInstance().executeNonQuery(string.Format("INSERT INTO Questions (questionText,questionVote1,questionVote2,questionVote3,questionVote4,questionTrueVote,questionDifficultyLevel,subjectId,lessonId,questionPicture,questionSolution) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", bunifuMaterialTextbox1.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox3.Text, bunifuMaterialTextbox4.Text, bunifuMaterialTextbox5.Text, comboBox1.Text, comboBox4.Text,comboBox3.Text,comboBox2.Text,bunifuMaterialTextbox7.Text,textBox1.Text));
        }
        public void clearAllTextbox()
        {

            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox2.Text = "";
            bunifuMaterialTextbox3.Text = "";
            bunifuMaterialTextbox4.Text = "";
            bunifuMaterialTextbox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            selectQuestions();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            insertQuestions();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            clearAllTextbox();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            updateQuestions();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            deleteQuestions();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = DataBase.getInstance().executeDataTable("Select * from Lessons");
        }
    }
}
