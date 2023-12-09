using DomainLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //One - to - One relationship between ApplicationUser and Doctor
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.Doctor)
                .WithOne(d => d.User)
                .HasForeignKey<Doctor>(d => d.User_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // One-to-One relationship between ApplicationUser and Patient
            modelBuilder.Entity<ApplicationUser>()
                .HasOne(a => a.Patient)
                .WithOne(p => p.User)
                .HasForeignKey<Patient>(p => p.User_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-One relationship between Doctor and Specialization
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Specialization)
                .WithMany(s => s.Doctors)
                .HasForeignKey(d => d.Specialize_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-One relationship between Patient and Discount
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Discount)
                .WithMany(d => d.Patients)
                .HasForeignKey(p => p.Discount_Id)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-One relationship between Appointment and Doctor
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-One relationship between Appointment and Patient
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-One relationship between Appointment and Discount
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Discount)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DiscountId)
                .OnDelete(DeleteBehavior.NoAction);

            // Many-to-One relationship between Time and Appointment
            modelBuilder.Entity<Time>()
                .HasOne(t => t.Appointment)
                .WithMany(a => a.Times)
                .HasForeignKey(t => t.Appointment_Id)
                .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(modelBuilder);

        }

    }
}
