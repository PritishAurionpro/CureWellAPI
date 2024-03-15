using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CureWell.Models;
using Microsoft.EntityFrameworkCore;

namespace CureWell.Database
{
    public class CureWellDbContext : DbContext
    {
        public CureWellDbContext(DbContextOptions<CureWellDbContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpecialization> DoctorSpecializations { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
    }
}