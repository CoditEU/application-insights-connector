﻿using System.Threading.Tasks;
using System.Web.Http;

namespace TomKerkhove.Connectors.ApplicationInsights.Controllers
{
    [RoutePrefix("api/v1")]
    public class EventsController : ApiController
    {
        [HttpPost]
        [Route("events")]
        public async Task<IHttpActionResult> WriteEvent()
        {
            return Ok();
        }
    }
}
