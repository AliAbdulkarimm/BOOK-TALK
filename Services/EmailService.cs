using BookTalk.Models;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

    //smtp.gmail.com Requires 
    //SSL: Yes Requires TLS: Yes(if available) 
    //Requires Authentication: Yes 
    //Port for SSL: 465 
    //Port for TLS / STARTTLS: 587

public class EmailService
{
    private readonly string smtpServer = "smtp.gmail.com";  // POP3/Imap -> get your emails
    private readonly int portNumber = 587;
    private readonly bool enableSSL = true;
    private readonly string emailFrom = "booktalk.contact@gmail.com";
    private readonly string password = "BookTalker3k$";


    public bool SendEmail()
    {

        string emailTo = "mommeisa@gmail.com";
        string subject = "Hello World!";
        string body = "This is our first email";

        StringBuilder builder = new StringBuilder();

        try
        {

            using (StreamReader reader = File.OpenText("./Layouts/GenericEmailLayout.html"))
            {
                builder.Append(reader.ReadToEnd());
            }

            builder.Replace("#subject#", subject);
            builder.Replace("#body#", body);

        }
        catch
        {
            return false;
        }


        using (MailMessage mail = new MailMessage())
        {


            mail.From = new MailAddress(emailTo, "BookTalk Support");
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = builder.ToString();
            mail.IsBodyHtml = true;

            try
            {
                using (SmtpClient smtp = new SmtpClient(smtpServer, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);

                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }

                return true;
            }
            catch(Exception ex)
            {
                string x = ex.ToString();
                return false;
            }
        
        
        
        }

        
    }

    public bool SendContactEmail(SendEmailModel model)
    {

        StringBuilder builder = new StringBuilder();

        try
        {
            using (StreamReader reader = File.OpenText("./Layouts/ContactEmailLayout.html"))
            {
                builder.Append(reader.ReadToEnd());
            }

            builder.Replace("#from#", model.Email);
            builder.Replace("#message#", model.Message);

        }
        catch
        {
            return false;
        }


        using (MailMessage mail = new MailMessage())
        {

            mail.From = new MailAddress(emailFrom, "BookTalk Support");
            mail.To.Add(emailFrom);
            mail.Subject = $"Email from ({model.Email})";
            mail.Body = builder.ToString();
            mail.IsBodyHtml = true;

            try
            {
                using (SmtpClient smtp = new SmtpClient(smtpServer, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);

                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }

                return true;
            }
            catch (Exception ex)
            {
                string x = ex.ToString();
                return false;
            }

        }

    }
}
