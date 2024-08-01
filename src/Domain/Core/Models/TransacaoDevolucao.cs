using api_transacao.Domain.Core.Enums;

namespace api_transacao.Domain.Core.Models
{
    public record TransacaoDevolucao
    {
        public EnumSituacaoLivro SituacaoLivro { get; set; }

        public required string IdRfidUsuario { get; set; } // id do usuário
        public required string IdRfidLivro { get; set; } // id do livro

        public DateOnly DataDevolucao { get; set; } // 
        public DateOnly DataEsperadaDevolucao { get; set; } 


    }
}
