﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebDemo.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public string JustApi()
        {
            return "it is working......";
        }
    }
}
