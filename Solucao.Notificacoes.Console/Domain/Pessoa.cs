using FluentValidator;
using FluentValidator.Validation;

namespace Solucao.Notificacoes.Console.Domain
{
    public class Pessoa : Notifiable
    {
        public Pessoa(string nome, string email)
        {
           
            Nome = nome;
            Email = email;

            AddNotifications(new ValidationContract()
                .HasMinLen(Nome, 3, "Nome", "Precisa ter no mínimo 3 caracteres")
                .HasMaxLen(Nome, 10, "Nome", "Precisa ter no maximo 10 caracteres")
                .IsEmail(email, email, "Email nao e valido")                
                );
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
