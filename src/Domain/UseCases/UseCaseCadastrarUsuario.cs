using api_cadastro.Domain.Core.Base;
using api_cadastro.Domain.Core.Models;
using api_cadastro.Domain.Core.Ports.Inbound.UseCases;

namespace api_cadastro.Domain.UseCases
{
    public class UseCaseCadastrarUsuario : IUseCaseCadastrarUsuario
    {
        public Task<BaseReturn> Execute(TransacaoUsuario transacao)
        {
            throw new NotImplementedException();
        }
    }
}
