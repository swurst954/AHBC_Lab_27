using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AHBC_Lab27.Controllers
{
    public class WeatherController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {"/points/39.0693,-94.6716"};
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

    }
}
