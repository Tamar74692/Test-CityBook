using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;

namespace WebAPI.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins:"*",headers:"*",methods:"*")]
    public class PersonController : ApiController
    {
        PersonBL personBL = new PersonBL();

        // GET: api/Person
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        [HttpPost]
        [Route("api/Person/Post")]
        public void Post([FromBody]PersonDTO person)
        {
            personBL.AddPerson(person);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
