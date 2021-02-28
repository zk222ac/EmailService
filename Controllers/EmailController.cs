using EmailService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailService.Controllers
{
    public class EmailController : Controller
    {
        //Turn on the Access for less secure apps
        public async Task<IActionResult> Index(Email email)
        {
            if (ModelState.IsValid)
            {
                MailMessage mMessage = new MailMessage();
                mMessage.To.Add(email.To);
                mMessage.Subject = email.Subject;
                mMessage.Body = email.Body;
                mMessage.IsBodyHtml = false;
                mMessage.From = new MailAddress("zukh4321@gmail.com");
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                // smtp 
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("zukh4321@gmail.com", "Roskilde001!");
                
                await smtpClient.SendMailAsync(mMessage);
                ViewData["Message"] = "Message has been send Succesfully";
            }
            return View();
        }

       
    }
   
}
