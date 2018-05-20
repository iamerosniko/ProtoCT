using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BW.APIHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Tables;
using Newtonsoft.Json;

namespace BW.Controllers.FrontendControllers
{
    [Produces("application/json")]
    [Route("api/Applications")]
    public class ApplicationsController : Controller
    {
        private ApiServices _api;

        [HttpGet]
        public async Task<List<Applications>> Get()
        {
            _api = new ApiServices("applications", null);
            return JsonConvert.DeserializeObject<List<Applications>>(await _api.Get());
        }   
    }
}