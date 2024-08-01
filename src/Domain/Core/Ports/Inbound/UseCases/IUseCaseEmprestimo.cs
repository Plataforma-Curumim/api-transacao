using api_transacao.Domain.Core.DTO.Base;
using api_transacao.Domain.Core.Models;
using api_transacao.Domain.Core.DTO.Command;

namespace api_transacao.Domain.Core.Ports.Inbound.UseCases
{
    public interface IUseCaseEmprestimo
    {
        Task<BaseReturn<CommandEmprestimo>> Execute(CommandEmprestimo command);
    }
}
}