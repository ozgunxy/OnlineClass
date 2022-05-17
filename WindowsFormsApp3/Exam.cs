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
    public class Exam
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4T09HNO;Initial Catalog=OnlineClass;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlCommand cmdd;
        SqlDataReader Red;
        public int QuestionId { get; set; }
        public int[] SorularId = new int[100];
        public int DogruSayisi { get; set; } = 0;
        public int YanlisSayisi { get; set; } = 0;
        public int BosSayisi { get; set; } = 0;
        public int QuestionNumber { get; set; } = 0;

        public int[] DereceliSorularId = new int[5];
        public static int ExamTotalPoint { get; set; } = 100;
        public int StudentId { get; set; }
        public int ExamPoint { get; set; }

        int temp;
        public Exam()
        {

        }

        public void Sorular()
        {

            for (int i = 0; i < 10; i++)
            {
            f:

                cmd = new SqlCommand("SELECT TOP 1 Question.questionId FROM Question ORDER BY NEWID()", conn);
                cmdd = new SqlCommand("SELECT COUNT(questionId) FROM QuestionStats WHERE questionId  = @Id and StudentId = @stdId ", conn);

                conn.Open();
                temp = (int)cmd.ExecuteScalar();
                cmdd.Parameters.AddWithValue("@Id", temp);
                cmdd.Parameters.AddWithValue("@stdId", StudentId);
                //temp2 = (int)cmdd.ExecuteScalar();
                if ((int)cmdd.ExecuteScalar() < 1)
                {
                    SorularId[i] = temp;
                    QuestionNumber++;
                    cmdd.Parameters.Clear();

                    conn.Close();
                }
                else
                {
                    conn.Close();
                    cmdd.Parameters.Clear();
                    goto f;
                }
                conn.Close();
            }
        }

        public void TrueSoruLar()
        {
            cmd = new SqlCommand("SELECT COUNT(StudentId) FROM QuestionStats WHERE StudentId = @stdId", conn);
            cmd.Parameters.AddWithValue("@stdId", StudentId);
            conn.Open();
            if ((int)cmd.ExecuteScalar() == 0)
            {
                MessageBox.Show("Dogru Soruu Bulunmadi!!");
                return;
            }
            else if ((int)cmd.ExecuteScalar() == 1)
            {
                cmd = new SqlCommand("SELECT TOP 1 QuestionStats.questionId FROM QuestionStats WHERE StudentId =@stdId ORDER BY NEWID()", conn);
                cmd.Parameters.AddWithValue("@stdId", StudentId);
                SorularId[QuestionNumber] = (int)cmd.ExecuteScalar();
                QuestionNumber++;

            }
            else if ((int)cmd.ExecuteScalar() == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    cmd = new SqlCommand("SELECT TOP 1 QuestionStats.questionId FROM QuestionStats WHERE StudentId =@stdId ORDER BY NEWID()", conn);
                    cmd.Parameters.AddWithValue("@stdId", StudentId);
                    SorularId[QuestionNumber] = (int)cmd.ExecuteScalar();
                    QuestionNumber++;
                }

            }
            else if ((int)cmd.ExecuteScalar() >= 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    cmd = new SqlCommand("SELECT TOP 1 QuestionStats.questionId FROM QuestionStats WHERE StudentId =@stdId ORDER BY NEWID()", conn);
                    cmd.Parameters.AddWithValue("@stdId", StudentId);
                    SorularId[QuestionNumber] = (int)cmd.ExecuteScalar();
                    QuestionNumber++;
                }
            }
        }

        public void SaveResults()
        {
            cmd = new SqlCommand("INSERT INTO Exams (examTotalPoint,examNumberCorrect,examNumberWrong,examNumberNull,studentId) VALUES (@examtotalpoint,@examnumbercorrect,@examnumberWrong,@examNumberNull,@studentId)", conn);

            cmd.Parameters.AddWithValue("@examtotalpoint", ExamTotalPoint);
            cmd.Parameters.AddWithValue("@examnumbercorrect", DogruSayisi);
            cmd.Parameters.AddWithValue("@examnumberWrong", YanlisSayisi);
            cmd.Parameters.AddWithValue("@examNumberNull", BosSayisi);
            cmd.Parameters.AddWithValue("@studentId", StudentId);

            cmd.ExecuteNonQuery();



        }

    }
}
