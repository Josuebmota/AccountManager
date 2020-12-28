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
            context.Despesa.Add(item);
            context.SaveChanges();
        }

        public List<Despesa> GetAll()
        {
            return context.Despesa.ToList();
        }
        public Despesa Find(int id)
        {
            return context.Despesa.FirstOrDefault(d => d.id == id);
        }
        public void Update(Despesa item)
        {
            context.Despesa.Update(item);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var despesa = context.Despesa.First(d => d.id == id);
            context.Despesa.Remove(despesa);
            context.SaveChanges();
        }

    }
}
