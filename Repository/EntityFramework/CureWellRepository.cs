using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CureWell.Database;
using CureWell.Models;

namespace CureWell.Repository.EntityFramework
{
    public class CureWellRepository : ICureWellRepository
    {
        private CureWellDbContext _context;
        public CureWellRepository(CureWellDbContext context)
        {
            _context = context;
        }
        public List<Doctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }
        public List<Specialization> GetAllSpecialization()
        {
            return _context.Specializations.ToList();
        }
        public List<Surgery> GetAllSurgeryForToday(DateTime date)
        {
            return _context.Surgeries.Where( surgery => surgery.SurgeryDate == date).ToList();
        }
        public Doctor AddDoctor(Doctor doctor) 
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
           return doctor;
        }
        public Specialization AddSpecialization(Specialization specialization) 
        {
            _context.Specializations.Add(specialization);
            _context.SaveChanges();
           return specialization;
        }
        public Surgery AddSurgery(Surgery surgery) 
        {
            _context.Surgeries.Add(surgery);
            _context.SaveChanges();
           return surgery;
        }
        public Doctor UpdateDoctorDetails(int doctorId, Doctor doctor) 
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
            return doctor;
        }
        public Surgery UpdateSurgery(Surgery surgery) 
        {
            _context.Surgeries.Update(surgery);
            _context.SaveChanges();
            return surgery;
        }

        public Doctor GetDoctorById(int id)
        {
            return _context.Doctors.Where( doctor => doctor.DoctorId == id).FirstOrDefault();
        } 
        public Surgery GetSurgeryById(int id)
        {
            return _context.Surgeries.Where( surgery => surgery.SurgeryId == id).FirstOrDefault();
        } 
    }
}