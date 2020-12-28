using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Services.Interface;
using AccountManager.Repositories.Interface;
using AccountManager.Data;
using AccountManager.Models;

namespace AccountManager.Services
{
    public class MonitorandoService: IMonitorandoService
    {
        private readonly DataContext context;

        public MonitorandoService(DataContext dbcontext)
        {
            this.context = dbcontext;
        }

        public decimal AllDespesas()
        {
            var despesas = context.Despesa.Where(d => d.pago == false).ToList();
            var value = despesas.Sum(d => d.valor);
            return value;
        }
        public decimal AllReceitas()
        {
            var receitas = context.Receita.Where(d => d.pago == true).ToList();
            var value = receitas.Sum(d => d.valor);
            return value;
        }

        public decimal FindSale()
        {
            var money = AllReceitas() - AllDespesas();
            return money;
        }
    }
}
