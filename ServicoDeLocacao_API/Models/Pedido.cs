using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace ServicoDeLocacao_API.Models
{
    class Pedido
    {
        public double Pagamento { get; set; }
        public double Taxa { get; set; }

        public Pedido(double pagamento, double taxa)
        {
            Pagamento = pagamento;
            Taxa = taxa;
        }
        public double PagamentoTotal
        {
            get
            {
                return Pagamento + Taxa;
            }
        }
    }
}
