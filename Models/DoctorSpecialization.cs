using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CureWell.Models
{
    public class DoctorSpecialization
    {
        [Key]
        public int DoctorId { get; set; }
        public string SpecializationCode { get; set; }
        public DateTime SpecializationDate { get; set; }
    }
}