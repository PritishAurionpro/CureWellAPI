using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CureWell.Models
{
    public class Specialization
    {
        [Key]
        public string SpecializationCode { get; set; }
        public string SpecializationName { get; set; }
    }
}