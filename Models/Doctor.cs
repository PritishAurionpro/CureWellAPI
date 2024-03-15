using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureWell.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public bool IsDeleted { get; set; }

        public void MarkAsDelete()
        {
            IsDeleted = true;
        }
        public void update(string doctorName)
        {
            DoctorName = doctorName;
        }
    }
}