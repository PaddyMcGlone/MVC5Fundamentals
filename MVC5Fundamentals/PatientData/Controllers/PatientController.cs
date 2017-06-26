using PatientData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatientData.Controllers
{
    public class PatientController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public PatientController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Patient> Get()
        {
            var allPatients =  _context.Patients.ToList();
            return allPatients;
        }

        // The HttpResponseMessage version
        //public HttpResponseMessage Get(int id)
        //{
        //    var patient = _context.Patients.SingleOrDefault(p => p.Id == id);
        //    return patient == null
        //        ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient Not Found")
        //        : Request.CreateResponse(patient);
        //}

        // The IHttpActionResult version
        public IHttpActionResult Get(int id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.Id == id);

            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        [Route("api/patient/{id}/medications")]
        public HttpResponseMessage GetMedication(int id)
        {
            var medication = _context.Medications.SingleOrDefault(m => m.Id == id);
            return medication == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Medication not found")
                : Request.CreateResponse(medication);
        }
    }
}

