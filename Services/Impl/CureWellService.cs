using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CureWell.Database;
using CureWell.Models;
using CureWell.Repository;

namespace CureWell.Services.Impl
{
    public class CureWellService : ICureWellService
    {
        private ICureWellRepository _cureWellRepository;
        private CureWellDbContext _context;
        public CureWellService(CureWellDbContext context, ICureWellRepository cureWellRepository) 
        {
            _context = context;
            _cureWellRepository = cureWellRepository;
        }

        public List<Doctor> GetAllDoctors() 
        {
            List<Doctor> doctors = new List<Doctor>();
            var doctorQuery = _cureWellRepository.GetAllDoctors();
            foreach (var doctor in doctorQuery)
            {
                if(!doctor.IsDeleted)
                    doctors.Add(doctor);
            }
            return doctors;
        }
        public List<Specialization> GetAllSpecialization() 
        {
            var  specializations = _cureWellRepository.GetAllSpecialization();
            return specializations;
        }
        public List<Surgery> GetAllSurgeryForToday(DateTime date)
        {
            return _cureWellRepository.GetAllSurgeryForToday(date);
        }

        public Doctor AddDoctor(Doctor doctor)
        {
            return _cureWellRepository.AddDoctor(doctor);
        }
        public Specialization AddSpecialization(Specialization specialization)
        {
            return _cureWellRepository.AddSpecialization(specialization);
        }
        public Surgery AddSurgery(Surgery surgery)
        {
            return _cureWellRepository.AddSurgery(surgery);
        }
        public Doctor UpdateDoctorDetails(int doctorId, Doctor doctor)
        {
            var updateDoctor = _cureWellRepository.GetDoctorById(doctorId);
            updateDoctor.update(doctor.DoctorName);
            _context.SaveChanges();
            return doctor;
        }
        public Surgery UpdateSurgery(int surgeryId, Surgery surgery)
        {
            var updateSurgery = _cureWellRepository.GetSurgeryById(surgeryId);
            updateSurgery.update(surgery);
            _context.SaveChanges();
            return updateSurgery;
        }

        public void DeleteDoctor(int doctorId)
        {
            var doctor = _cureWellRepository.GetDoctorById(doctorId);
            doctor.MarkAsDelete();
            _context.SaveChanges();
        }        
    }
}