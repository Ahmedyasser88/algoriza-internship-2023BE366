﻿using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO
{
    public class DoctorBookingAppointmentViewModel
    {
        public DateTime AppointmentDay { get; set; }
        public A_Status AppointmentStatus { get; set; }
    }
}
