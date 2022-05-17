using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class SifremiUnuttumSayfasi : Form
    {
        public SifremiUnuttumSayfasi()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        String random;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            //int sayi1, sayi2, sayi3;
            //int harfdegeri;
            //sayi1 = rastgele.Next(1, 9);
            //sayi2 = rastgele.Next(0, 9);
            //sayi3 = rastgele.Next(0, 9);
            //harfdegeri = rastgele.Next(65, 91);
            //char karakter;
            //karakter = Convert.ToChar(harfdegeri);
            //random = sayi1.ToString() + sayi2.ToString() + karakter + sayi3.ToString();


            //SmtpClient sc = new SmtpClient();
            //sc.Port = 587;
            //sc.Host = "smtp.gmail.com";
            //sc.EnableSsl = true;

            //string kime = bunifuMaterialTextbox1.Text;
            //string konu = "Yeni Şifreniz :" + random;
            //DataBase.getInstance().executeNonQuery(string.Format("Update Students set Where studentId={0}"));

            //sc.Credentials = new NetworkCredential("xml.ozgun@gmail.com", "");
            //MailMessage mail = new MailMessage();
            //mail.From = new MailAddress("posta@gmail.com", "Ahmet Cansever");
            //mail.To.Add(kime);
            ////mail.To.Add("alici2@mail.com");
            ////mail.CC.Add("alici3@mail.com");
            ////mail.CC.Add("alici4@mail.com");
            //mail.Subject = konu;
            //mail.IsBodyHtml = true;
            //mail.Body = icerik;
            //mail.Attachments.Add(new Attachment(DosyaYolu));
            //sc.Send(mail);
        }
    }
}
