using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homecare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayerController : ControllerBase
    {
        // GET: api/Payer
        [HttpGet]
        public IEnumerable<Payer> Get()
        {
            List<Payer> payerlist= new List<Payer>();

            Payer c1 = new Payer("Lishmi", "Davis", "2345678987", "kdlr");
            payerlist.Add(c1);

            return payerlist;
        }

        // GET: api/Payer/5
        [HttpGet("{id}", Name = "PayerGet")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Payer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Payer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
public class Payer
{
    public Payer(string lname, string fname, string contact, string discipline1)
    {
        lastName = lname;
       firstName = fname;
        contactNumber = contact;
        city = discipline1;
    }
    public string lastName { get; set; }
    public string firstName { get; set; }
    public string contactNumber { get; set; }
    public string city { get; set; }
}
