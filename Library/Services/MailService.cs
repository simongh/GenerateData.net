using System;
using System.Net.Mail;

namespace GenerateData.Services
{
	internal class MailService : IMailService
	{
		public void Send(MailMessage message)
		{
			if (message == null)
				throw new ArgumentNullException("message");
			if (message.To.Count == 0)
				throw new ArgumentException("Message is missing receipients");

			using (var client = new SmtpClient())
			{
				client.Send(message);
			}
		}
	}
}
