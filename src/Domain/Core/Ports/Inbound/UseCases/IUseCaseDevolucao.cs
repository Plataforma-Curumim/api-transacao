using api_transacao.Domain.Core.DTO.Base;
using api_transacao.Domain.Core.Models;

namespace api_transacao.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCaseDevolucaoLivro
    {
        Task<BaseReturn> Execute(TransacaoDevolucao devolucao);
    }
}