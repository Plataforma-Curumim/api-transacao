using System;

namespace api_transacao.Domain.Core.DTO.Command
{
    public record CommandEmprestimo
    {
        public string IdRfidUsuario { get; set; }
        public string IdRfidLivro { get; set; }
        public DateOnly DataEmprestimo { get; set; }
    }
}
