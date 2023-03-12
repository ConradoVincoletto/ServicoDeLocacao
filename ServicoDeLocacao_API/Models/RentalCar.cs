namespace ServicoDeLocacao_API.Models
{
    public class RentalCar
    {
        public DateTime Começo { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Pedido Pedido { get; set; }
    }
}
