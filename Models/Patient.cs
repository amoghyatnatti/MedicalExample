using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalExample.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public DateTime DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
