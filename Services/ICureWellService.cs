using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CureWell.Models;

namespace CureWell.Services
{
    public interface ICureWellService
    {
        public List<Doctor> GetAllDoctors();
        public List<Specialization> GetAllSpecialization();
        public List<Surgery> GetAllSurgeryForToday(DateTime date);
        public Doctor AddDoctor(Doctor doctor);
        public Specialization AddSpecialization(Specialization specialization);
        public Surgery AddSurgery(Surgery surgery);
        public Doctor UpdateDoctorDetails(int doctorId, Doctor doctor);
        public Surgery UpdateSurgery(int surgeryId, Surgery surgery);
        public void DeleteDoctor(int doctorId);
    }
}