using System;
using System.Net.Mail;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Alıcı e-posta adresi: ");
                string Mail = Console.ReadLine();
                Console.Write("Gönderici isim: ");
                string Name = Console.ReadLine();
                Console.Write("Konu: ");
                string Subject = Console.ReadLine();
                Console.Write("Mesaj: ");
                string Text = Console.ReadLine();

                MailMessage Message = new MailMessage();
                SmtpClient Client = new SmtpClient();

                Client.Credentials = new System.Net.NetworkCredential("senneanlatiyonbolum@outlook.com", "Cc12345678");
                Client.Port = 587;
                Client.Host = "smtp.outlook.com";
                Client.EnableSsl = true;

                Message.Body = Text;
                Message.Subject = Subject;
                Message.From = new MailAddress("senneanlatiyonbolum@outlook.com", Name);
                Message.To.Add(Mail);

                Client.Send(Message);
                Console.WriteLine("Başarıyla yazdığınız e-posta gönderildi.");
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
    }
}
