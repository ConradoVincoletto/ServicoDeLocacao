using Microsoft.EntityFrameworkCore;
using ServicoDeLocacao_API.Data;
using ServicoDeLocacao_API.DTOs;
using ServicoDeLocacao_API.Models;
using System;
namespace ServicoDeLocacao_API.Serviços
{
    
    public class ServicoDeLocacaoDeCarro
    {


        private readonly Contexto _contexto;
        public ServicoDeLocacaoDeCarro(Contexto contexto)
        {
            _contexto = contexto;
        }

        public int Inserir(PedidoDTO pedidoDTO)
        {
            Pedido pedido = new Pedido();            
            pedido.Taxa = pedidoDTO.Taxa;
            pedido.Pagamento = pedidoDTO.Pagamento;
            _contexto.Add(pedido);
            _contexto.SaveChanges();

            return pedido.Id;

        }
    }
}
