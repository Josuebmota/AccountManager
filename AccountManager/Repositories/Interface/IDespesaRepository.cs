using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Models;

namespace AccountManager.Repositories.Interface
{
    public interface IDespesaRepository
    {
        void Add(Despesa item);
        List<Despesa> GetAll();
        Despesa Find(int id);
        void Delete(int id);
        void Update(Despesa item);
    }
}
