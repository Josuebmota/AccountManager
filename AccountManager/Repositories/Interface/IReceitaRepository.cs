using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Models;

namespace AccountManager.Repositories.Interface
{
    public interface IReceitaRepository
    {
        void Add(Receita item);
        List<Receita> GetAll();
        Receita Find(int id);
        void Delete(int id);
        void Update(Receita item);
    }
}
