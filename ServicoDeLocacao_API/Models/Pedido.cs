using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicoDeLocacao_API.Models
{
    public class Pedido
    {
        public double Pagamento { get; set; }
        public double Taxa { get; set; }
        public double PagamentoBasico { get; }

        public Pedido(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }
    }
}
