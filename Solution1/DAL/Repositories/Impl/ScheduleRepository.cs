using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.DAL.Entities;
using DAL.EF.Catalog.DAL.EF;
using DAL.Repositories.Interfaces;
using DAL.Repositories.Interfaces.Catalog.DAL.Repositories.Interfaces;

namespace Catalog.DAL.Repositories.Impl
{
    public class ScheduleRepository
    : BaseRepository<Schedule>, IScheduleRepository
    {
        internal ScheduleRepository(BusBookingContext context)
        : base(context)
        {
        }
    }
}

