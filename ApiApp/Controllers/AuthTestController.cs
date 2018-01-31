using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiApp.Controllers
{
    [Route(("api/[controller]"))]
    public class AuthTestController : Controller
    {
        [HttpGet]
        [Authorize]
        public string Get()
        {
            return "Congratulations you are authenticated";
        }
    }
}