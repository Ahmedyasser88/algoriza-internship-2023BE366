﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer.Context;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainLayer.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AccountType")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("User_FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DomainLayer.Models.Appointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AppointmentDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("AppointmentStatus")
                        .HasColumnType("int");

                    b.Property<string>("DiscountId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DoctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Time_Id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("DomainLayer.Models.Booking", b =>
                {
                    b.Property<string>("Booking_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Appointment_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Booking_Status")
                        .HasColumnType("int");

                    b.Property<string>("Dcotor_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discount_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Patient_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Booking_Id");

                    b.HasIndex("Appointment_Id");

                    b.HasIndex("Dcotor_Id");

                    b.HasIndex("Discount_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DomainLayer.Models.Discount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discount_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discount_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("DomainLayer.Models.Doctor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Specialize_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Specialize_Id");

                    b.HasIndex("User_Id")
                        .IsUnique()
                        .HasFilter("[User_Id] IS NOT NULL");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("DomainLayer.Models.DoctorAvailability", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("DoctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("DoctorAvailability");
                });

            modelBuilder.Entity("DomainLayer.Models.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discount_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("User_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Discount_Id");

                    b.HasIndex("User_Id")
                        .IsUnique()
                        .HasFilter("[User_Id] IS NOT NULL");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("DomainLayer.Models.Specialization", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Specialize_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialization");
                });

            modelBuilder.Entity("DomainLayer.Models.Time", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Appointment_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("_Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Appointment_Id");

                    b.ToTable("Time");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DomainLayer.Models.Appointment", b =>
                {
                    b.HasOne("DomainLayer.Models.Discount", "Discount")
                        .WithMany("Appointments")
                        .HasForeignKey("DiscountId");

                    b.HasOne("DomainLayer.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DomainLayer.Models.Patient", null)
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId");

                    b.Navigation("Discount");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DomainLayer.Models.Booking", b =>
                {
                    b.HasOne("DomainLayer.Models.Appointment", "Appointment")
                        .WithMany("Bookings")
                        .HasForeignKey("Appointment_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DomainLayer.Models.Doctor", "Doctors")
                        .WithMany("Bookings")
                        .HasForeignKey("Dcotor_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DomainLayer.Models.Discount", "Discount")
                        .WithMany("Bookings")
                        .HasForeignKey("Discount_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DomainLayer.Models.Patient", "Patient")
                        .WithMany("Bookings")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Appointment");

                    b.Navigation("Discount");

                    b.Navigation("Doctors");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DomainLayer.Models.Doctor", b =>
                {
                    b.HasOne("DomainLayer.Models.Specialization", "Specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("Specialize_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DomainLayer.Models.ApplicationUser", "User")
                        .WithOne("Doctor")
                        .HasForeignKey("DomainLayer.Models.Doctor", "User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Specialization");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DomainLayer.Models.DoctorAvailability", b =>
                {
                    b.HasOne("DomainLayer.Models.Doctor", "Doctor")
                        .WithMany("Availabilities")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DomainLayer.Models.Patient", b =>
                {
                    b.HasOne("DomainLayer.Models.Discount", "Discount")
                        .WithMany("Patients")
                        .HasForeignKey("Discount_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DomainLayer.Models.ApplicationUser", "User")
                        .WithOne("Patient")
                        .HasForeignKey("DomainLayer.Models.Patient", "User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Discount");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DomainLayer.Models.Time", b =>
                {
                    b.HasOne("DomainLayer.Models.Appointment", "Appointment")
                        .WithMany("Times")
                        .HasForeignKey("Appointment_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DomainLayer.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DomainLayer.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainLayer.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DomainLayer.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomainLayer.Models.ApplicationUser", b =>
                {
                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("DomainLayer.Models.Appointment", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Times");
                });

            modelBuilder.Entity("DomainLayer.Models.Discount", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Bookings");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("DomainLayer.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Availabilities");

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DomainLayer.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("DomainLayer.Models.Specialization", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
