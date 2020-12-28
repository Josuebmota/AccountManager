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
    public class ReceitaController : Controller
    {
        private readonly IReceitaRepository receitaRepository;

        public ReceitaController(IReceitaRepository receita)
        {
            this.receitaRepository = receita;
        }

        [HttpPost]
        public ActionResult<Receita> Post([FromBody] Receita model)
        {
            if (ModelState.IsValid)
            {
                receitaRepository.Add(model);
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpGet]
        public ActionResult<List<Receita>> GetAll()
        {
            return receitaRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetReceita")]
        public ActionResult<Receita> GetById(int id)
        {
            var item = receitaRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPut("{id}")]
        public ActionResult<Receita> Update([FromBody] Receita model, int id)
        {
            var itemDespesa = receitaRepository.Find(id);
            if (itemDespesa == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                receitaRepository.Update(model);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Receita> Delete(int id)
        {
            var itemDespesa = receitaRepository.Find(id);
            if (itemDespesa == null)
            {
                return NotFound();
            }
            else if (ModelState.IsValid)
            {
                receitaRepository.Delete(id);
                return NoContent();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
