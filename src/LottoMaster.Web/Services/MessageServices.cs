﻿using Microsoft.Extensions.OptionsModel;
using System.Configuration;
using System.Threading.Tasks;
using Twilio;


namespace LottoMaster.Web.Services
{
    // This class is used by the application to send Email and SMS
    // when you turn on two-factor authentication in ASP.NET Identity.
    // For more details see this link http://go.microsoft.com/fwlink/?LinkID=532713
    public class AuthMessageSender : IEmailSender, ISmsSender
    {
        private readonly TwilioRestClient _client;

        public AuthMessageSender(IOptions<TwilioCredential> client)
        {
            _client = new TwilioRestClient(client.Value.AccountSID, client.Value.AuthToken);
        }
 


        public Task SendEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }

        public Task SendSmsAsync(string number, string message)
        {
            // Plug in your SMS service here to send a text message.
            _client.SendMessage("17142032735", number, message);
            return Task.FromResult(0);
        }
    }
    public class TwilioCredential
    {
        public string AccountSID;
        public string AuthToken;
    }

}
