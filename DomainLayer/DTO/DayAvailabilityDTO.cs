using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class DayAvailabilityDTO
    {
        public DayOfWeek Day { get; set; }
        public List<TimeSpan> AvailableTimes { get; set; }
    }
}
