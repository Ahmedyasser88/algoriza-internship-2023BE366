using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class DoctorAppointmentDTO
    {
        public double Price { get; set; }
        public List<DayAvailabilityDTO> DaysAvailability { get; set; }
    }

}
