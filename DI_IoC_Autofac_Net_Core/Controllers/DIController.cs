using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DI_IoC_Autofac_Net_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DIController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Autofac".ToString();
        }
    }
}
