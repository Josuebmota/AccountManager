using Microsoft.EntityFrameworkCore;
using AccountManager.Models;

namespace AccountManager.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}

        public DbSet<Despesa> Despesas { get; set; }

    }

};



