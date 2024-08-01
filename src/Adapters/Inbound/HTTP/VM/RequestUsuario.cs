namespace api_transacao.Adapters.Inbound.HTTP.VM
{
    public record RequestUsuario
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
        public int Situacao { get; set; }
        public int TipoUsuario { get; set; }

    }
}
