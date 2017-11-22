﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Web;
using DAL;
using DAL.Repositories;
using Entities.Entities;

namespace ServerMonitorAPI.Logic
{
    public class EmailSender
    {
        private readonly IRepository<EmailRecipient> emailRepo = new DALFacade().GetCRUDEmailRecipientRepository();
        public void SendEmail(Event et)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("vetechnorepley@gmail.com");
                List<EmailRecipient> er = emailRepo.ReadAll();
                foreach (var emailRecipient in er)
                {
                    mail.To.Add(emailRecipient.Email);
                }
                //test email
                mail.To.Add("vetechnorepley@gmail.com");
                mail.Subject = "Server warning!";
                mail.Body = EmailMessage(et);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("vetechnorepley@gmail.com", "Vetech2017");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private string EmailMessage(Event et)
        {
            string msg = "Warning: " + et.EventType.Name + Environment.NewLine+"On date: " + et.EventType.Created + Environment.NewLine+
                         "On server with this name: " + et.Server.ServerName;
            return msg;
        }
         
    }
}