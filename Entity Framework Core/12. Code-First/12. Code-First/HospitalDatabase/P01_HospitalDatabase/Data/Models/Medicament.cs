using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Medicament
    {
        public Medicament()
        {
            this.PatientMedicaments = new HashSet<PatientMedicament>();
        }

        public int MedicamentId { get; set; }

        public string Name { get; set; }

        public ICollection<PatientMedicament> PatientMedicaments { get; set; }
    }
}
