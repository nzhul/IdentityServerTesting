using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetIdentity.Controllers.api
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)] // !!! VERY IMPORTANT!
    [Route("/api/customers")]
    public class ProtectedController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            // This endpoint will be visible only through API call and not with direct browser access
            return Ok(new[] { "One", "Two", "Three" });
        }
    }
}
