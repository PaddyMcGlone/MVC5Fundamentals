using System.Collections.Generic;

namespace PatientData.Models
{
    public class Patient
    {                
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Medication> Medications { get; set; }
        public virtual ICollection<Aliment> Aliments { get; set; }
    }
}