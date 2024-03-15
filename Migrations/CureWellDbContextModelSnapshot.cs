﻿// <auto-generated />
using System;
using CureWell.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CureWell.Migrations
{
    [DbContext(typeof(CureWellDbContext))]
    partial class CureWellDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CureWell.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("CureWell.Models.DoctorSpecialization", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SpecializationCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SpecializationDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DoctorId");

                    b.ToTable("DoctorSpecializations");
                });

            modelBuilder.Entity("CureWell.Models.Specialization", b =>
                {
                    b.Property<string>("SpecializationCode")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("SpecializationName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SpecializationCode");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("CureWell.Models.Surgery", b =>
                {
                    b.Property<int>("SurgeryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("SurgeryCategory")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("SurgeryDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SurgeryId");

                    b.ToTable("Surgeries");
                });
#pragma warning restore 612, 618
        }
    }
}
