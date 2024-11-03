using System.Net.Mail;
using System.Net;

namespace smtp_client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Send test letter...");

            // Настройки SMTP
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;

            string emailFrom = "daniilexampl@gmail.com";
            string password = "myyh tgxm gcsq tqxn";

            string emailTo = "daniil.konovalenko1@nure.ua";
            string subject = "Test letter";
            string body = "This is test letter, sent via SMTP-client on C#.";

            string attachmentPath = @"C:\path\to\your\attachment.txt";

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    if (!string.IsNullOrEmpty(attachmentPath))
                    {
                        if (System.IO.File.Exists(attachmentPath))
                        {
                            Attachment attachment = new Attachment(attachmentPath);
                            mail.Attachments.Add(attachment);
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Attachment not found along the path {attachmentPath}");
                        }
                    }

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;

                        await smtp.SendMailAsync(mail);
                        Console.WriteLine("The email has been successfully sent!");
                    }
                }
            }
            catch (SmtpException smtpEx)
            {
                Console.WriteLine($"SMTP error: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
