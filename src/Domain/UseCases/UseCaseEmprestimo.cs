using api_transacao.Domain.Core.Ports.Inbound.UseCases;
using api_transacao.Adapters.Inbound.HTTP.Mapping;
using api_transacao.Domain.Core.DTO.Command;
using api_transacao.Domain.Core.DTO.Base;

namespace api_transacao.Domain.UseCases

{
    public class UseCaseEmprestimo : IUseCaseEmprestimo
    {
        private readonly IEmprestimoRepository _repository;

        public UseCaseEmprestimo(IServiceProvider provider)
        {
            _repository = provider.GetService<IEmprestimoRepository>();
        }

        public async Task<BaseReturn<CommandEmprestimo>> Execute(CommandEmprestimo command)
        {
            try
            {
                var repositoryModel = MappingToEmprestimo.ToRepository(command);
                var responseRepository = await _repository.EmprestarLivro(repositoryModel);

                if (responseRepository.IdRfidLivro == null)
                {
                    var error = new BaseError
                    {
                        code = "400",
                        message = "Erro ao registrar empréstimo do livro.",
                    };

                    return new BaseReturn<CommandEmprestimo>().Error(EnumState.BUSINESS, error);
                }

                var response = MappingToEmprestimo.ToCommand(responseRepository);
                return new BaseReturn<CommandEmprestimo>().Success(response);
            }
            catch (Exception ex)
            {
                var error = new BaseError("500", ex.Message);
                return new BaseReturn<CommandEmprestimo>().Error(EnumState.SYSTEM, error);
            }
        }
    }
}
