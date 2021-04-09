using System.Net;
using System.Net.Mail;
using FluentEmail.Core;
using Microsoft.AspNetCore.Mvc;
namespace EmailSender
{
public class MailSenderController : Controller
{
    private const string pass= "";
    public IActionResult Index()
    {
        return View();
    }
    public string SendEmail(string Name, string Email, string Message){
        
        try
        {
            // Credentials
            var credentials = new NetworkCredential("emailsenderf0f7b@gmail.com", pass);
            // Mail message
            var mail = new MailMessage()
            {
                From = new MailAddress("noreply@codinginfinite.com"),
                Subject = "Password Reset",
                Body = Message
            };
            mail.IsBodyHtml = true;
            mail.To.Add(new MailAddress(Email));
           
            var client = new SmtpClient()
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Credentials = credentials
            };
            client.Send(mail);
            return "Email Sent Successfully!";
        }
        catch (System.Exception e)
        {
            return e.Message;
        }
        
    }
}
}