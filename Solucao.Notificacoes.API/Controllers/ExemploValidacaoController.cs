using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using System;
using Solucao.Notificacoes.API.Domain;

namespace Solucao.Notificacoes.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExemploValidacaoController : ControllerBase
    {
        private readonly IValidator<Pessoa> _pessoaValidator;

        public ExemploValidacaoController(IValidator<Pessoa> pessoaValidator)
        {
            _pessoaValidator = pessoaValidator;
        }

        [HttpPost]
        public IActionResult Post(Pessoa pessoa)
        {
            var validationResult = _pessoaValidator.Validate(pessoa);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            // O objeto é válido, prossiga com o processamento.
            // ...
            return Ok("Pessoa válida.");
        }
    }
}
