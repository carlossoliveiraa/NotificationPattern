using FluentValidator;
using Solucao.Notificacoes.Console.Domain;
using Solucao.Notificacoes.Console.Result;

namespace Solucao.Notificacoes.Console
{
    public class Verificadora : Notifiable
    {
        public NotificationResultDto Execute()
        {
            var pessoa = new Pessoa("Teste", "teste@hotmail.com");
            return Verifica(pessoa);
        }

        private NotificationResultDto Verifica(Pessoa pessoa)
        {
            //valida as entidades
           AddNotifications(pessoa.Notifications);

            if (Invalid)
            {
                return new NotificationResultDto(false, "Por favor valide os campos: ", Notifications);
            }

            return new NotificationResultDto(true, "Sucesso", null);
        }
    }
}
