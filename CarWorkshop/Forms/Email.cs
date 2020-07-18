﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop.Forms
{
    public partial class Email : Form
    {
        private readonly string email;

        public string EmailSender { get; set; }
        public Email(string emailTo)
        {
            email = emailTo;
            InitializeComponent();
            tbTo.Text = email;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            MailMessage message = new MailMessage();
                message.From = new MailAddress(tbFrom.Text);
                message.To.Add(new MailAddress(email));
                message.Subject = tbSubject.Text;
                message.Body = tbBody.Text;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "poczta.o2.pl";
                smtp.Credentials = new NetworkCredential(tbFrom.Text, tbPassword.Text);
                smtp.EnableSsl = true;
                smtp.Send(message);
                MessageBox.Show("Email Send");
                this.Close();


            }
            catch
            {
                MessageBox.Show("Check your email username and password");
                
            }
           
        }

    }
}
