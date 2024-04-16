using api_cadastro.Domain.Core.Enums;

namespace api_cadastro.Domain.Core.Models
{
    public record TransacaoUsuario
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string IdRfid { get; set; }
        public EnumSituacaoUsuario Situacao { get; set; }
        public EnumTiposUsuario TipoUsuario { get; set; }
         
    }
}
