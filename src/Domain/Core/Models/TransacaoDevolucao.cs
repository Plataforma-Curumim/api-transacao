using api_cadastro.Domain.Core.Enums;

namespace api_cadastro.Domain.Core.Models
{
    public record TransacaoDevolucao
    {
        public required string IdRfidUsuario { get; set; } // id do usuário
        public required string IdRfidLivro { get; set; } // id do livro

        public DateOnly DataDevolucao { get; set; } // 
        public DateOnly DataEsperadaDevolucao { get; set; } 


    }
}
