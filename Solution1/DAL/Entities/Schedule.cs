using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DAL.Entities
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string DayOfWeek { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
    }
}