using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Repositories.Interface;
using AccountManager.Data;
using AccountManager.Models;

namespace AccountManager.Repositories
{
    public class DespesaRepository: IDespesaRepository
    {
        private readonly DataContext context;

        public DespesaRepository(DataContext dbcontext)
        {
            this.context = dbcontext;
        }

        public void Add(Despesa item)
        {
            context.Despesas.Add(item);
            context.SaveChanges();
        }

        public List<Despesa> GetAll()
        {
            return context.Despesas.ToList();
        }
        public Despesa Find(int id)
        {
            return context.Despesas.FirstOrDefault(d => d.id == id);
        }
        public void Update(Despesa item)
        {
            context.Despesas.Update(item);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var despesa = context.Despesas.First(d => d.id == id);
            context.Despesas.Remove(despesa);
            context.SaveChanges();
        }

    }
}
