using System.Collections.Generic;

namespace Catalog.DAL.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public IEnumerable<Schedule> Schedules { get; set; }
    }
}
