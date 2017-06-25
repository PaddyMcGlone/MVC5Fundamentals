using PatientData.Models;
using System.Collections.Generic;

namespace PatientData.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;            
        }

        protected override void Seed(Models.ApplicationDbContext context)
        {            
            context.Patients.AddOrUpdate(p => p.Name,
                new Patient
                {
                    Id = 321,
                    Name = "Pat",
                    Medications = new List<Medication> { new Medication { Name = "Paracetamol"} },
                    Aliments = new List<Aliment> { new Aliment { Name = "Headache"} }
                });
        }
    }
}
