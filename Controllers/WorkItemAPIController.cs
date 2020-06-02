using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkItemWebhook.Models;

namespace WorkItemWebhook.Controllers
{
    [RoutePrefix("api/workitems")]
    public class WorkItemAPIController : ApiController
    {

        CreateWorkitemController control = new CreateWorkitemController();
        // GET: api/WorkItemAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("create")]
        public IHttpActionResult CreateWI()
        {
            string requestData = Request.Content.ReadAsStringAsync().Result;
            WebHookRequestModel webhook = JsonConvert.DeserializeObject<WebHookRequestModel>(requestData);
            control.CreateWork(webhook);
            return Ok(true);
        }


        // GET: api/WorkItemAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WorkItemAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WorkItemAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WorkItemAPI/5
        public void Delete(int id)
        {
        }
    }
}
