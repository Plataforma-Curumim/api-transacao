using api_transacao.Domain.Core.Enums;
using api_transacao.Adapters.Inbound.HTTP.VM;
using api_transacao.Domain.Core.Enums;
using api_transacao.Domain.Core.Models;

namespace api_transacao.Adapters.Inbound.HTTP.Mapping
{
    public static class MappingToEmprestimo
    {
        public static Emprestimo ToEmprestimo(RequestEmprestimo request)
        {
            return new TransacaoEmprestimo
            {
                IdRfidUsuario = request.IdRfidUsuario,
                IdRfidLivro = request.IdRfidLivro,
                DataEmprestimo = request.DataEmprestimo,
                DataEsperadaDevolucao = request.DataEsperadaDevolucao,
                Situacao = request.Situacao switch
                {
                    0 => EnumSituacaoLivro.DISPONIVEL,
                    1 => EnumSituacaoLivro.EMPRESTADO,
       
                }
            };
        }
    }
}
