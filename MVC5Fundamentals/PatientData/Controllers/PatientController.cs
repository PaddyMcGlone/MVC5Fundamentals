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

        public HttpResponseMessage Get(int id)
        {
            var patient = _context.Patients.SingleOrDefault(p => p.Id == id);
            return patient == null
                ? Request.CreateErrorResponse(HttpStatusCode.NotFound, "Patient Not Found")
                : Request.CreateResponse(patient);
        }
    }
}
