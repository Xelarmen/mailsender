using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EASendMail;

namespace MailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string mail, sifre, gidenmail, konu, metin;
            mail = textBox1.Text;
            sifre = textBox2.Text;
            gidenmail = textBox3.Text;
            konu = textBox4.Text;
            metin = textBox5.Text;
            int secim = comboBox1.SelectedIndex;
            SmtpMail oMail = new SmtpMail("TryIt");
            SmtpClient oSmtp = new SmtpClient();

            oMail.From = mail;            // Gönderen Maili
            oMail.To = gidenmail;            // Gidecek olan mail
            oMail.Subject = konu;              // Mail konusu          
            oMail.TextBody = metin; // Mail metni
            
            if (secim == 0)
            {
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");            // SMTP server ismi
                oServer.Port = 465;            // Port no
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;            // ssl/tsl tespiti
                oServer.User = mail;
                oServer.Password = sifre;

                try
                {
                    textBox6.Text = "Gönderiliyor";
                    oSmtp.SendMail(oServer, oMail);
                    textBox6.Text = "Başarılı!";
                }
                catch (Exception ep)
                {
                    textBox6.Text = "Başarısız. Hata";
                    textBox6.Text += ep.Message + "Lütfen Sol Alttaki butondan sorunlar sayfasına bakın!";
                }


            }

            if (secim == 1)
            {
                SmtpServer oServer = new SmtpServer("smtp.yandex.com.tr");            // SMTP server ismi
                oServer.Port = 465;            // Port no
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;            // ssl/tsl tespiti
                oServer.User = mail;
                oServer.Password = sifre;

                try
                {
                    textBox6.Text = "Gönderiliyor";
                    oSmtp.SendMail(oServer, oMail);
                    textBox6.Text = "Başarılı!";
                }
                catch (Exception ep)
                {
                    textBox6.Text = "Başarısız. Hata";
                    textBox6.Text += ep.Message + "Lütfen Sol Alttaki butondan sorunlar sayfasına bakın!";
                }


            }
            if (secim == 2)
            {
                SmtpServer oServer = new SmtpServer("smtp.office365.com");            // SMTP server ismi
                oServer.Port = 587;            // Port no
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;            // ssl/tsl tespiti
                oServer.User = mail;
                oServer.Password = sifre;

                try
                {
                    textBox6.Text = "Gönderiliyor";
                    oSmtp.SendMail(oServer, oMail);
                    textBox6.Text = "Başarılı!";
                }
                catch (Exception ep)
                {
                    textBox6.Text = "Başarısız. Hata";
                    textBox6.Text += ep.Message+"Lütfen Sol Alttaki butondan sorunlar sayfasına bakın!";
                }


            }
            if (secim == -1)
            {

                textBox6.Text = "Başarısız. Lütfen Ayarlar'dan Mail Servisinizi Seçiniz...";
                          
            }


        }//button 

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.abdulkadirkaya.com.tr");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://abdulkadirkaya.com.tr/2019/07/18/mail-sender/"); 
        }
    }//form1
    }//mailsender

