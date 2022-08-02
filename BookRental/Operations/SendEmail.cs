using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BookRental.Operations
{
    public static class SendEmail
    {
        const string Host = "smtp-mail.outlook.com";
        const string Name = "Book Rental";
        const string UserName = "thudizin@outlook.com.br";
        const string Password = "Oliveirasilvatulio1";
        const int Port = 587;
        public static bool Send (string email, string subject, string mesage)
        {
            try
            {
                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress(UserName, Name)
                };

                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = mesage;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                using (SmtpClient smtp = new SmtpClient(Host, Port))
                {
                    smtp.Credentials = new NetworkCredential(UserName, Password);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);

                    return true;
                }

            }
            catch(Exception)
            {
                return false;
            }


        }
    }
}
