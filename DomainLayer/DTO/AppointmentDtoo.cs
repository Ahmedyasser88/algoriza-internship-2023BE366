using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class AppointmentDtoo
    {
        public DateTime Day { get; set; }
        public List<TimeDto> Times { get; set; }
    }

}
