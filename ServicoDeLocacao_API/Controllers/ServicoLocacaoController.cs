using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicoDeLocacao_API.Data;
using ServicoDeLocacao_API.DTOs;
using ServicoDeLocacao_API.Serviços;

namespace ServicoDeLocacao_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoLocacaoController : ControllerBase
    {
        private ServicoDeLocacaoDeCarro ServicoDeLocacaoDeCarro;

        private readonly Contexto _contexto;
        public ServicoLocacaoController(Contexto contexto)
        {
            _contexto = contexto;
            ServicoDeLocacaoDeCarro = new ServicoDeLocacaoDeCarro(_contexto);
        }
        
        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody]PedidoDTO pedidoDTO)
        {
            return Ok(ServicoDeLocacaoDeCarro.Inserir(pedidoDTO));
        }
    }
}
