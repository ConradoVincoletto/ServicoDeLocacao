namespace ServicoDeLocacao_API.DTOs
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = default!;
        public double Pagamento { get; set; }
        public double Taxa { get; set; }


    }
}
