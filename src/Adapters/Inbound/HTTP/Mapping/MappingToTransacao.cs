using api_transacao.Adapters.Inbound.HTTP.VM;
using api_transacao.Domain.Core.Enums;
using api_transacao.Domain.Core.Models;

namespace api_transacao.Adapters.Inbound.HTTP.Mapping
{
    public static class MappingToTransacao
    {
        public static TransacaoUsuario ToTransacao(RequestUsuario request)
        {
            return new TransacaoUsuario
            {
                Nome = request.Nome,
                CpfCnpj = request.CpfCnpj,
                Email = request.Email,
                Username = request.Username,
                Senha = request.Senha,
                DataNascimento = request.DataNascimento,
                Telefone = request.Telefone,
                Endereco = request.Endereco,
                IdRfid = request.IdRfid,
                Status = request.Status switch
                {
                    0 => EnumSituacaoUsuario.ATIVO,
                    1 => EnumSituacaoUsuario.ATIVO,
                    2 => EnumSituacaoUsuario.ATIVO,
                },
                TipoUsuario = request.TipoUsuario switch
                {
                    0 => EnumTiposUsuario.LEITOR,
                    1 => EnumTiposUsuario.FUNCIONARIO,
                    2 => EnumTiposUsuario.ADMINISTRADOR,
                }

            };
        }
    }
}

