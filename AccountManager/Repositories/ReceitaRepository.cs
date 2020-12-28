using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Repositories.Interface;
using AccountManager.Data;
using AccountManager.Models;

namespace AccountManager.Repositories
{
    public class ReceitaRepository:IReceitaRepository
    {
        private readonly DataContext context;

        public ReceitaRepository(DataContext dbcontext)
        {
            this.context = dbcontext;
        }

        public void Add(Receita item)
        {
            context.Receita.Add(item);
            context.SaveChanges();
        }

        public List<Receita> GetAll()
        {
            return context.Receita.ToList();
        }
        public Receita Find(int id)
        {
            return context.Receita.FirstOrDefault(r => r.id == id);
        }
        public void Update(Receita item)
        {
            context.Receita.Update(item);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var receita = context.Receita.First(r => r.id == id);
            context.Receita.Remove(receita);
            context.SaveChanges();
        }
    }
}
