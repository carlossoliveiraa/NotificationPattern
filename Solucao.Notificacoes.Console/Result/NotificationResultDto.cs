using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucao.Notificacoes.Console.Result
{
    public class NotificationResultDto
    {
        public NotificationResultDto(bool sucesso, string mensagem, object dados)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Dados = dados;
        }

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
        public object Dados { get; private set; }
    }
}
