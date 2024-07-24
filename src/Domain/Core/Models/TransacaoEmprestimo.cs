using api_cadastro.Domain.Core.Enums;

namespace api_cadastro.Domain.Core.Models
{
    public record TransacaoEmprestimo
    {
        public EnumSituacaoLivro SituacaoLivro { get; set; }

        public required string IdRfidUsuario { get; set; } // id do usuário
        public required string IdRfidLivro { get; set; } // id do livro

        public DateOnly DataEmprestimo { get; set; } // (USAR DATE SÓ!!!) dia em que foi efetuado emprestimo
        public DateOnly DataEsperadaDevolucao => DataEmprestimo.AddDays(14);                                            // incluir data que havia sido prevista a devolução?


    }
}
