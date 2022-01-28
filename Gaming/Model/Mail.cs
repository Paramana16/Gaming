using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Gaming.Helpers;

namespace Gaming.Model
{
	public class Mail
    {

		public static void MailSender(int check_code, string Adress)
        {
            var fromAddress = new MailAddress("nisancigaming@gmail.com");
            var toAddress = new MailAddress(Adress);
            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "GokmenBatu123.")
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { 
                    Body = check_code.ToString() ,
                    Subject= "Check Mail Adress"
                })
                {
                    smtp.Send(message);
                }
            }
        }

    }
}
