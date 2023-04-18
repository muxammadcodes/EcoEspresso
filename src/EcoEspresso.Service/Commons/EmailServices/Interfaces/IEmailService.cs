using EcoEspresso.Domain.Entities;

namespace EcoEspresso.Service.Commons.EmailServices.Interfaces
{
    public interface IEmailService
    {
        public Task SendAsync(EmailMessage emailMessage);
    }
}
