using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace TokenBasedAuthenticationWebAPI_Demo.Controllers.API
{
    public class TestController : ApiController
    {
        [Authorize(Roles = "SuperAdmin,Admin,User")]
        [HttpGet]
        [Route("api/test/resource1")]
        public IHttpActionResult GetResource1()
        {
            var identity = (ClaimsIdentity)User.Identity;
            return Ok("Hello: " + identity.Name);
        }

        [Authorize(Roles = "SuperAdmin, Admin")]
        [HttpGet]
        [Route("api/test/resource2")]
        public IHttpActionResult GetResource2()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var Email = identity.Claims.FirstOrDefault(c => c.Type == "Email").Value;
            var UserName = identity.Name;

            return Ok("Hello " + UserName + ", Your Email ID is :" + Email);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        [Route("api/test/resource3")]
        public IHttpActionResult GetResource3()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value);
            return Ok("Hello " + identity.Name + "Your Role(s) are: " + string.Join(",", roles.ToList()));
        }
    }
}
