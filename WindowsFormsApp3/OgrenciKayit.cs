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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcCon = new SqlConnection("Data Source=DESKTOP-4T09HNO;Initial Catalog=OnlineClass;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                if (bunifuMaterialTextbox5.Text == "" || bunifuMaterialTextbox1.Text == "" || bunifuMaterialTextbox6.Text == ""
                    || bunifuMaterialTextbox2.Text == "" || bunifuMaterialTextbox3.Text == "" || bunifuMaterialTextbox4.Text == "")
                {
                    MessageBox.Show("Basarisiz Kayit");
                    return;
                }
                sqlcCon.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students (studentName,studentSurname,studentPw,studentMail,studentUserName,studentPhoneNumber) VALUES (@FirtsName,@SurName,@Password,@Email,@UserName,@TelefonNo)", sqlcCon);
                cmd.Parameters.AddWithValue("@FirtsName", bunifuMaterialTextbox1.Text.Trim());
                cmd.Parameters.AddWithValue("@SurName", bunifuMaterialTextbox2.Text.Trim());
                cmd.Parameters.AddWithValue("@UserName", bunifuMaterialTextbox6.Text.Trim());
                cmd.Parameters.AddWithValue("@TelefonNo", bunifuMaterialTextbox3.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", bunifuMaterialTextbox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", bunifuMaterialTextbox5.Text.Trim());
                cmd.ExecuteNonQuery();
                sqlcCon.Close();
            }
        }
    }
}
