namespace Solucao.Notificacoes.API.Domain
{
    public class Pessoa 
    {
        public Pessoa(string nome, string email)
        {

            Nome = nome;
            Email = email;           
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
    }
}
