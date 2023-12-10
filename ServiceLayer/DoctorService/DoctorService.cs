using DomainLayer.DTO;
using DomainLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.DoctorRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DoctorService
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository= doctorRepository;
        }
        public async Task<List<Booking>> GetDoctorBookingsAsync(string doctorId, int pageSize, int pageNumber)
        {
            return await _doctorRepository.GetDoctorBookingsAsync(doctorId, pageSize, pageNumber);
        }

        public bool ConfirmCheckup(string bookingId)
        {
            return  _doctorRepository.ConfirmCheckup(bookingId);
        }

        public async Task<bool> CreateDoctorAppointment(DoctorAppointmentDTO doctorAppointmentDTO, string doctorId)
        {
            return await _doctorRepository.CreateDoctorAppointment(doctorAppointmentDTO, doctorId);
        }
        public async Task<bool> UpdateDoctorAvailability(string doctorId, string timeId, TimeSpan newTime)
        {
            return await _doctorRepository.UpdateDoctorAvailability(doctorId, timeId, newTime);
        }

        public bool DeleteDoctorTime(string doctorId, string timeId)
        {
            return _doctorRepository.DeleteDoctorTime(doctorId, timeId);
        }
    }
}
