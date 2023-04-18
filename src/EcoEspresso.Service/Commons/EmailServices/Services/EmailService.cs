using EcoEspresso.Domain.Entities;
using EcoEspresso.Service.Commons.EmailServices.Interfaces;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit.Text;
using MimeKit;
using MailKit.Net.Smtp;


namespace EcoEspresso.Service.Commons.EmailServices.Services;

public class EmailService : IEmailService
{
    private readonly IConfiguration configuration;
    public EmailService(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    public async Task SendAsync(EmailMessage emailMessage)
    {
        var email = new MimeMessage();
        email.From.Add(MailboxAddress.Parse(this.configuration["EmailAddress"]));
        email.To.Add(MailboxAddress.Parse(emailMessage.To));
        email.Subject = emailMessage.Subject;
        email.Body = new TextPart(TextFormat.Html) { Text = emailMessage.Body };
        ///
        var smpt = new SmtpClient();
        await smpt.ConnectAsync(this.configuration["Host"], 587, SecureSocketOptions.StartTls);
        await smpt.AuthenticateAsync(this.configuration["EmailAddress"], this.configuration["Password"]);
        await smpt.SendAsync(email);
        await smpt.DisconnectAsync(true);
    }
}
