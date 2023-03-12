using ServicoDeLocacao_API.Models;
using System;


namespace ServicoDeLocacao_API.Serviços
{
    public class ServicoDeLocacaoDeCarro
    {
        public double PrecoPorHora { get; set; }
        public double PrecoPorDia { get; set; }

        private ITaxaDeServiço _taxaDeServico;

        public ServicoDeLocacaoDeCarro(double precoPorHora, double precoPorDia, ITaxaDeServiço taxaDeServiço)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaDeServico = taxaDeServiço;
        }

        public void ProcessamentoDoPedido(RentalCar rentalCar)
        {
            TimeSpan duracao = rentalCar.Final.Subtract(rentalCar.Começo);

            double pagamentoBasico = 0;
            if(duracao.TotalHours <= 12.00)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double Taxa = _taxaDeServico.Taxa(pagamentoBasico);

            rentalCar.Pedido = new Pedido(pagamentoBasico, Taxa);
        }
    }
}
