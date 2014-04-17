using System.Net.Mail;

namespace GenerateData.Services
{
	public interface IMailService
	{
		void Send(MailMessage message);
	}
}
