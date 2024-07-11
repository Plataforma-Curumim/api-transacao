using api_cadastro.Domain.Core.Base;
using api_cadastro.Domain.Core.Models;

namespace api_transacao.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCaseEmprestimoLivro
    {
        Task<BaseReturn> Execute(TransacaoDevolucao devolucao);
    }
}