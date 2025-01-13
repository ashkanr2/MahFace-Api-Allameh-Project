using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;

namespace Mahface.Services.AppServices.Service
{

    public class EmailService : IEmailService
    {
        private readonly IEMailRepository _mailRepository;

        public EmailService(IEMailRepository eMailRepository)
        {
            _mailRepository = eMailRepository;
        }

        public async Task<bool> SendEmailAsync(string toEmail, string subject, string message)
        {
            var emailLog = new EmailLog
            {
                Id = new Guid(),
                ToEmail = toEmail,
                Subject = subject,
                Message = message,
                SentDate = DateTime.Now,
                Status = "Attempted",
                IsSuccess = false,
                ErrorDetails = string.Empty
            };

            try
            {
                string emailBody = " ";
                var setting = await _mailRepository.GetSetting();
                var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "EmailView", "EmailTemplate.html");
                if (templatePath!=null)
                {
                     var emailTemplate = await File.ReadAllTextAsync(templatePath);
                     emailBody = emailTemplate
                                     .Replace("{Title}", subject)
                                     .Replace("{Message}", message);
                }

                var client = new SmtpClient(setting.SMTPHost, setting.SMTPPort)
                {
                    EnableSsl = false,
                    Credentials = new NetworkCredential(setting.EmailAddress, setting.Password),
                    UseDefaultCredentials = false
                };

                // Create mail message
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(setting.EmailAddress, "Mahface Support"),
                    Subject = subject,
                    Body = templatePath==null ? message : emailBody,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(toEmail);

              
                await client.SendMailAsync(mailMessage);

                
                emailLog.Status = "Sent";
                emailLog.IsSuccess = true;
                emailLog.ErrorDetails = "Success";  
                await _mailRepository.LogEmailAsync(emailLog);

                return true;  
            }
            catch (Exception ex)
            {


                emailLog.ToEmail = toEmail;
                emailLog.Subject = subject;
                emailLog.Message = message;
                emailLog.SentDate = DateTime.Now;
                emailLog.Status = "Failed";
                emailLog.ErrorDetails = ex.Message; 
                emailLog.IsSuccess = false;
           
                 
                await _mailRepository.LogEmailAsync(emailLog);

                
                Console.WriteLine($"Failed to send email: {ex.Message}");
                return false;  
            }
        }

    }


}