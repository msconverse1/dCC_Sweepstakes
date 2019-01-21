using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Google.Apis.Auth.OAuth2;
using System.Security.Cryptography.X509Certificates;
using MailKit.Security;

namespace msc_Sweepstakes
{
   static class SendEmail
    {
       // static  string filepath = "https://www.googleapis.com/oauth2/v1/certs";

        static public  void EmailToSendAsync(string name, string Email, string winner, string SweepstakesName)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Mr.SweepStakes", "{RaveRedRose@live.com}"));
            message.To.Add(new MailboxAddress(name, Email));
            message.Subject = "Reslut of the Sweepstakes";
            var body= new TextPart("plain");
            if (name == winner)
            {
                 body = new TextPart("plain")
                {
                    Text = name + @" Good Day,
                           
                 The Result of our Contest Has Been Decided an we would like to announce that You are the Winner of " + SweepstakesName +".\n"+
                 @" We hope you will join us again when we run our next Sweepstakes

                 -- Mr.Sweepstakes"
                };
            }
            else
            {
                 body = new TextPart("plain")
                {
                    Text = name + @" Good Day,
                           
                        The Result of our Contest Has Been Decided an we would like to announce that " + winner + " is the winner of the " + SweepstakesName +
                     @" We hope you will join us again when we run our next Sweepstakes

                 -- Mr.Sweepstakes"
                };
            }
            message.Body = body;
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, MailKit.Security.SecureSocketOptions.SslOnConnect);
                client.Authenticate("matt.conversedcc@gmail.com", "devCodeCamp");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
 }

