using api_transacao.Domain.Core.Base;
using api_transacao.Domain.Core.Models;
using api_transacao.Domain.Core.Ports.Inbound.UseCases;

namespace api_transacao.Domain.UseCases
{
	public class UseCaseEmprestimo : IUseCaseEmprestimo
	{
		public Task<BaseReturn> Execute(TransacaoDevolucao devolucao)
		{
			throw new NotImplementedException();
		}
	}
}
