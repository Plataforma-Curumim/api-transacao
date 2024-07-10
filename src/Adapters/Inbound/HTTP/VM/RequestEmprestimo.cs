namespace api_cadastro.Adapters.Inbound.HTTP.VM
{
    public class RequestEmprestimo
    {
        public string IdRfidUsuario { get; set; }

        public string IdRfidLivro { get; set; }

        public DateOnly DataEmprestimo { get; set; }
    }
}
