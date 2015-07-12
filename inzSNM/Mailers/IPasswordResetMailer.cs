using Mvc.Mailer;
using inzSNM.Mailers.Models;

namespace inzSNM.Mailers
{ 
    public interface IPasswordResetMailer
    {
			MvcMailMessage PasswordReset(MailerModel model);
	}
}