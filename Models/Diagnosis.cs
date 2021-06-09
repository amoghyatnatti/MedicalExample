using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalExample.Models
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public int PatientId { get; set; }
        public int ProviderId { get; set; }
        public string DiagnosisInfo { get; set; }
    }

}
