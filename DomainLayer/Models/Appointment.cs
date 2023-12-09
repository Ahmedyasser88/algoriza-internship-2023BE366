using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DomainLayer.Models
{
    public class Appointment
    {
        [Key]
        public string Id { get; set; }
        public DateTime AppointmentDay { get; set; }
        public string AppointmentStatus { get; set; }

        // Foreign keys
        [ForeignKey("Doctor")]
        public string DoctorId { get; set; }
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        [ForeignKey("Discount")]
        public string DiscountId { get; set; }

        // Navigation properties
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Discount Discount { get; set; }
        public ICollection<Time> Times { get; set; }

    }
    

}
