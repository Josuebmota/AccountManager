using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManager.Models;

namespace AccountManager.Services.Interface
{
    public interface IMonitorandoService
    {
        decimal AllDespesas();
        decimal AllReceitas();
        decimal FindSale();

    }
}
