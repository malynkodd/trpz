using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.DAL.Repositories.Impl;
using Catalog.DAL.Repositories.Interfaces;
using DAL.Repositories.Interfaces.Catalog.DAL.Repositories.Interfaces;

namespace Catalog.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IScheduleRepository Schedules { get; }
        void Save();
    }
}
