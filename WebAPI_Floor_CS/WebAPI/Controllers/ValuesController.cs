using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/CRUD")]
    public class ValuesController : ApiController
    {
         [Route("myName")]
         [HttpGet]
         [ActionName ("myName")]
        public IHttpActionResult Get()
        {
          
            return Ok("lol");
        }


       [Route("getId")]
       [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.NotFound,"enterd id "+id) ;
        }

        

        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
