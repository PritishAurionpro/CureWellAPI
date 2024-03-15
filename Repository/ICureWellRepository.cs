using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CureWell.Models;

namespace CureWell.Repository
{
    public interface ICureWellRepository
    {
        public List<Doctor> GetAllDoctors();
        public List<Specialization> GetAllSpecialization();
        public List<Surgery> GetAllSurgeryForToday(DateTime date);
        public Doctor AddDoctor(Doctor doctor);
        public Specialization AddSpecialization(Specialization specialization);
        public Surgery AddSurgery(Surgery surgery); 
        public Doctor UpdateDoctorDetails(int doctorId, Doctor doctor);
        public Surgery UpdateSurgery(Surgery surgery);
        public Doctor GetDoctorById(int id);
        public Surgery GetSurgeryById(int id);
    }
}