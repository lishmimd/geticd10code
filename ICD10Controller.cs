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
    public class ICD10Controller : ControllerBase
    {
        // GET: api/ICD10
        [HttpGet]
        public IEnumerable<icd10Class> Get()
        {
            List<icd10Class> icd10List = new List<icd10Class>();

            icd10Class a1 = new icd10Class("A102", "abc");
            icd10List.Add(a1);

            return icd10List;


        }

        // GET: api/ICD10/5
        [HttpGet("{id}", Name = "icd10Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ICD10
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ICD10/5
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
public class icd10Class
{
    public icd10Class(string code1, string display1)
    {
        code =code1;
        display= display1;
        
    }
    public string code { get; set; }
    public string display { get; set; }

    internal static void Add(icd10Class a1)
    {
        throw new NotImplementedException();
    }
}

    


