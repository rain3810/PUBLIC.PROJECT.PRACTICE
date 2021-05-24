using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API_TEST.Controllers
{
    [Produces("application/json")]
    [Route("api/Park_Get_Car_In")]
    public class Park_Get_Car_InController : Controller
    {
        // GET: api/Park_Get_Car_In
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Park_Get_Car_In/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Park_Get_Car_In
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Park_Get_Car_In/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
