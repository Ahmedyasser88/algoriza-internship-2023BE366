﻿using DomainLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.PatientRepository
{
    public interface IPatientRepository
    {
        IEnumerable<DoctorDto> GetDoctors(int page, int pageSize, string search);
        bool BookAppointment(string patientId, string timeId);
        Task<List<BookingDetailsDto>> GetPatientBookingsAsync(string patientId);
    }
}
