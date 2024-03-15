using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CureWell.Models
{
    public class Surgery
    {
        public int DoctorId { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime StartTime { get; set; }
        public string SurgeryCategory { get; set; }
        public DateTime SurgeryDate { get; set; }
        public int SurgeryId { get; set; }

        public void update(Surgery surgery)
        {
            DoctorId = surgery.DoctorId;
            EndTime = surgery.EndTime;
            StartTime = surgery.StartTime;
            SurgeryCategory = surgery.SurgeryCategory;
            SurgeryDate = surgery.SurgeryDate;
        }
    }
}