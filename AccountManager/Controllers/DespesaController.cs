using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Repositories.Interface;
using AccountManager.Models;

namespace AccountManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DespesaController : Controller
    {
        private readonly IDespesaRepository despesaRepository;

        public DespesaController(IDespesaRepository despesa)
        {
            this.despesaRepository = despesa;
        }

        [HttpPost]
        public ActionResult<Despesa> Post([FromBody] Despesa model)
        {
            if (ModelState.IsValid)
            {
                despesaRepository.Add(model);
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        public ActionResult<List<Despesa>> GetAll()
        {
            return despesaRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetDespesa")]
        public ActionResult<Despesa> GetById(int id)
        {
            var item = despesaRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public ActionResult<Despesa> Update([FromBody] Despesa model, int id)
        {
            var itemDespesa = despesaRepository.Find(id);
            if (itemDespesa == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                despesaRepository.Update(model);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Despesa> Delete(int id)
        {
            var itemDespesa = despesaRepository.Find(id);
            if (itemDespesa == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                despesaRepository.Delete(id);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
