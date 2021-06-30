using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;

namespace WebAPI.Controllers
{
    [System.Web.Http.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChildController : ApiController
    {
        ChildBL ChildBL = new ChildBL();

        // GET: api/Child
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Child/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Child
        [HttpPost]
        [Route("api/Child/Post")]
        public void Post([FromBody]ChildDTO child)
        {
            ChildBL.AddChild(child);

        }

        // PUT: api/Child/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Child/5
        public void Delete(int id)
        {
        }
    }
}
