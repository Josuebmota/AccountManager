using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Services.Interface;
using AccountManager.Models;

namespace AccountManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MonitorandoController : Controller
    {
        private readonly IMonitorandoService monitoringRepository;

        public MonitorandoController(IMonitorandoService monitoring)
        {
            this.monitoringRepository = monitoring;
        }

        [HttpGet("FindSale",Name = "FindSale")]
        public ActionResult<Decimal> FindSale()
        {
            var value = monitoringRepository.FindSale();
            return Ok(value);
        }

        [HttpGet("GetAllDespesas", Name = "GetAllDespesas")]
        public ActionResult<Decimal> GetAllDespesas()
        {
            var value = monitoringRepository.AllDespesas();
            return Ok(value);
        }

        [HttpGet("GetAllReceitas", Name = "GetAllReceitas")]
        public ActionResult<Decimal> GetAllReceitas()
        {
            var value = monitoringRepository.AllReceitas();
            return Ok(value);
        }

    }
}
