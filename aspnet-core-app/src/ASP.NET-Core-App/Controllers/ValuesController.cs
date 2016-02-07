using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using System.Diagnostics;
using Microsoft.AspNet.Hosting;

namespace ASP.NET_Core_App.Controllers
{
    [Route("api/")]
    public class ValuesController : Controller
    {        
        [HttpGet]
        public async Task<string> Get()
        {
            return await Task.FromResult(string.Format("Hello World! from ASP.NET_Core_App - {0}", new HostingEnvironment().EnvironmentName));
        }       
    }
}
