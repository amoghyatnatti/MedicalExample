using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalExample.Models
{
    public class PatientOverview
    {
        public Patient PatientInfo { get; set; }
        public IEnumerable<MedicalExample.Models.PatientDiagnosisView> DiagnosesList { get; set; }
    }
}
