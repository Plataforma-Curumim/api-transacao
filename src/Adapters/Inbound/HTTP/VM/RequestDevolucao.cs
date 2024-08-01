namespace api_transacao.Adapters.Inbound.HTTP.VM
{
    public class RequestDevolucao
    {
        public string IdRfidUsuario { get; set; }

        public string IdRfidLivro { get; set; }

        public DateOnly DataDevolucao { get; set; }
    }
}
