using api_cadastro.Domain.Core.Base;
using api_cadastro.Domain.Core.Models;

namespace api_cadastro.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCaseCadastrarUsuario
    {
        public Task<BaseReturn> Execute(TransacaoUsuario transacao);
    }
}
