namespace ServicoDeLocacao_API.Models
{

    public class RentalCar
    {
        
        public int Id { get; set; }
        public string Nome { get; set; } = default!;        
        public DateTime Começo { get; set; }        
        public DateTime Final { get; set; }       
        public string Veiculo { get; set; }

        public Pedido Pedidos { get; set; }


    }
}
