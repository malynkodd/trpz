using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog.DAL.Entities;
using Catalog.DAL.Repositories.Interfaces;
using DAL.EF.Catalog.DAL.EF;
using DAL.Repositories.Interfaces;

namespace Catalog.DAL.Repositories.Impl
{
    public class ClientRepository
    : BaseRepository<Client>, IClientRepository
    {
        internal ClientRepository(BusBookingContext context)
        : base(context)
        {
        }
    }
}