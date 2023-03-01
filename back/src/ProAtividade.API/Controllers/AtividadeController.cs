using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.Models;

namespace ProAtividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Atividade> Get(){
            return new List<Atividade>() {
                new Atividade(),
                new Atividade(),
                new Atividade()
            };
        }

        [HttpGet("{id}")]
        public string Get(int id){
            return $"Meu primeiro método get com parâmetro {id}";
        }


        [HttpPost]
        public Atividade Post(Atividade atividade){
            return atividade;
        }

        [HttpPut]
        public string Put(){
            return "Meu primeiro método Put";
        }

        [HttpDelete]
        public string Delete(){
            return "Meu primeiro método Delete";
        }
    }
}