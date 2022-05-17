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
using System.IO;
using System.Drawing.Imaging;


namespace WindowsFormsApp3
{
    public partial class SınavOl : Form
    {
        int H, M, S = 59;
        public int a = 0;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T09HNO;Initial Catalog=OnlineClass;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlCommand cmdd;
        SqlDataReader Red;

        public Students student = new Students();

        Exam ex = new Exam();

        public SınavOl()
        {
            InitializeComponent();
        }

        private void SınavOl_Load(object sender, EventArgs e)
        {
            ex.StudentId = student.StudentId;
            ex.Sorular();
            ex.TrueSoruLar();

            cmdd = new SqlCommand("SELECT questionText,questionVote1,questionVote2,questionVote3,questionVote4,questionTrueVote,questionPicture FROM Question WHERE questionId = @Id", conn);
            cmdd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
            conn.Open();
            Red = cmdd.ExecuteReader();
            while (Red.Read())
            {
                textBox5.Text = Red.GetValue(0).ToString();
                textBox1.Text = Red.GetValue(1).ToString();
                textBox2.Text = Red.GetValue(2).ToString();
                textBox3.Text = Red.GetValue(3).ToString();
                textBox4.Text = Red.GetValue(4).ToString();
                truVote = Red.GetValue(5).ToString();
                Byte[] img = (Byte[])Red.GetValue(6);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

            conn.Close();
            a++;
            M = ex.QuestionNumber;
            M--;

            label6.Text = Convert.ToString(M);
            label8.Text = Convert.ToString(S);
        }
        string truVote;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (radioButton1.Text == truVote)
                {
                    int count;
                    cmd = new SqlCommand("SELECT COUNT(questionId) FROM QuestionStats WHERE questionId = @Id and StudentId = @StdId", conn);
                    cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                    cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (count > 0)
                    {
                        cmd = new SqlCommand("UPDATE QuestionStats SET TrueTimes +=1 WHERE questionId = @Id and StudentId = @StdId ", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO QuestionStats (questionId,StudentId,TrueTimes,trueQuestion) VALUES (@Id,@StdId,1,0)", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    ex.DogruSayisi++;
                }
                else
                {
                    ex.YanlisSayisi++;
                }
            }
            else if (radioButton2.Checked)
            {
                if (radioButton2.Text == truVote)
                {
                    int count;
                    cmd = new SqlCommand("SELECT COUNT(questionId) FROM QuestionStats WHERE questionId = @Id and StudentId = @StdId", conn);
                    cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                    cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (count > 0)
                    {
                        cmd = new SqlCommand("UPDATE QuestionStats SET TrueTimes +=1 WHERE questionId = @Id and StudentId = @StdId ", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO QuestionStats (questionId,StudentId,TrueTimes,trueQuestion) VALUES (@Id,@StdId,1,0)", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    ex.DogruSayisi++;
                }
                else
                {
                    ex.YanlisSayisi++;
                }
            }
            else if (radioButton3.Checked)
            {
                if (radioButton3.Text == truVote)
                {
                    int count;
                    cmd = new SqlCommand("SELECT COUNT(questionId) FROM QuestionStats WHERE questionId = @Id and StudentId = @StdId", conn);
                    cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                    cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (count > 0)
                    {
                        cmd = new SqlCommand("UPDATE QuestionStats SET TrueTimes +=1 WHERE questionId = @Id and StudentId = @StdId ", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO QuestionStats (questionId,StudentId,TrueTimes,trueQuestion) VALUES (@Id,@StdId,1,0)", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    ex.DogruSayisi++;
                }
                else
                {
                    ex.YanlisSayisi++;
                }
            }
            else if (radioButton4.Checked)
            {
                if (radioButton4.Text == truVote)
                {
                    int count;
                    cmd = new SqlCommand("SELECT COUNT(questionId) FROM QuestionStats WHERE questionId = @Id and StudentId = @StdId", conn);
                    cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                    cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                    conn.Open();
                    count = (int)cmd.ExecuteScalar();
                    conn.Close();
                    if (count > 0)
                    {
                        cmd = new SqlCommand("UPDATE QuestionStats SET TrueTimes +=1 WHERE questionId = @Id and StudentId = @StdId ", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        cmd = new SqlCommand("INSERT INTO QuestionStats (questionId,StudentId,TrueTimes,trueQuestion) VALUES (@Id,@StdId,1,0)", conn);
                        cmd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
                        cmd.Parameters.AddWithValue("@StdId", ex.StudentId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    ex.DogruSayisi++;
                }
                else
                {
                    ex.YanlisSayisi++;
                }
            }
            else
            {
                ex.BosSayisi++;
            }

            cmdd = new SqlCommand("SELECT questionText,questionVote1,questionVote2,questionVote3,questionVote4,questionTrueVote,questionPicture FROM Question WHERE questionId = @Id", conn);
            cmdd.Parameters.AddWithValue("@Id", ex.SorularId[a]);
            conn.Open();
            Red = cmdd.ExecuteReader();
            while (Red.Read())
            {
                textBox5.Text = Red.GetValue(0).ToString();
                textBox1.Text = Red.GetValue(1).ToString();
                textBox2.Text = Red.GetValue(2).ToString();
                textBox3.Text = Red.GetValue(3).ToString();
                textBox4.Text = Red.GetValue(4).ToString();
                truVote = Red.GetValue(5).ToString();
                Byte[] img = (Byte[])Red.GetValue(6);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

            conn.Close();
            a++;
            Delete();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SinavBitir();
        }

        public void Delete()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (S > 0)
            {
                S--;
                label8.Text = Convert.ToString(S);
            }
            if (M > 0 && S == 0)
            {
                M -= 1;
                S += 59;
                label8.Text = Convert.ToString(S);
                label6.Text = Convert.ToString(M);
            }
            if (M < 10)
            {
                label6.Text = "0" + Convert.ToString(M);

            }
            if (S < 10)
            {
                label8.Text = "0" + Convert.ToString(S);
            }
            if (a == ex.QuestionNumber)
            {
                bunifuThinButton21.Enabled = false;
            }
            if (bunifuThinButton21.Enabled == false)
            {
                bunifuThinButton22.Enabled = true;
            }
            if (M == 0 && S == 0)
            {
                SinavBitir();
                timer1.Enabled = false;
            }
        }

      

        public void SinavBitir()
        {
            ex.SaveResults();
            OgrenciAnaMenu Menu = new OgrenciAnaMenu();
            Menu.student = student;
            this.Hide();
            Menu.Show();

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}