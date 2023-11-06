using FluentValidation;
using Solucao.Notificacoes.API.Domain;

namespace Solucao.Notificacoes.API.Validacao
{
    public class PessoaValidator : AbstractValidator<Pessoa>
    {
        public PessoaValidator()
        {
            RuleFor(pessoa => pessoa.Nome)
                .Length(3, 10)
                .WithMessage("O campo nome deve ter entre 3 e 10 caracteres.");

            RuleFor(pessoa => pessoa.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("O campo email deve ser um endereço de e-mail válido.");
        }
    }
}
