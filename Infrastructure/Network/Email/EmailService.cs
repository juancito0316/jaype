using Common.Logging;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Infrastructure.Network.Email
{
    public class EmailService
    {
        readonly ILogger _logger;

        public EmailService(ILogger logger) {
            this._logger = logger;
        }

        public void Send(string from, string to, string subject, string body) {
            var now = DateTime.UtcNow;
            var smtpClient = new SmtpClient();
            var mailMessage = new MailMessage(from, to, subject, body);

            try {
                smtpClient.SendMailAsync(mailMessage);
            } catch (Exception ex) {
                _logger.Log(now, ex.ToString());
            }
            
        }
    }
}
