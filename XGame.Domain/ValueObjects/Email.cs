using prmToolkit.NotificationPattern;

namespace XGame.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(email => email.Endereco, "Email invalido");
        }

        public string Endereco { get; private set; }
    }
}
