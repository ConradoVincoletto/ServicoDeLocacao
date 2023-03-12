namespace ServicoDeLocacao_API.Models
{
    public class Pedido
    {
        public Pedido(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double Pagamento { get; set; }
        public double Taxa { get; set; }
        public double PagamentoBasico { get; }
    }
}
