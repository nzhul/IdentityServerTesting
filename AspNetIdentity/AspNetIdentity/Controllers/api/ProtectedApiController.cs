using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetIdentity.Controllers.api
{
    public class ProtectedApiController : Controller
    {
        [HttpGet]
        [Authorize]
        public async Task<object> Protected()
        {
            return "Protected area";
        }
    }
}
