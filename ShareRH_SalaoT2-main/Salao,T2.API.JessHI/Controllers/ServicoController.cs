using Microsoft.AspNetCore.Mvc;
using SalaoT2.Dominio;
using System.Collections.Generic;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Salao_T2.API.JessHI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        private MinhaBaseServicos baseServico;

        public ServicoController()
        {
            baseServico = new MinhaBaseServicos();
        }

        // GET: api/<ServicoController>
        [HttpGet]
        public IEnumerable<Servico> Get()
        {
            return baseServico.Servicos; 
        }

        // GET api/<ServicoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ServicoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ServicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ServicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
