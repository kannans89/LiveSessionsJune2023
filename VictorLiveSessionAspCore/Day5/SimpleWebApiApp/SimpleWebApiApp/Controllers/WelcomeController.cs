using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {

        [HttpGet] //read(R)
        public string Get() {
            return "Get called";
        }

        [HttpPost]
        public string Post() {//creat(C)
            return "post called";
        }

        [HttpPut]
        public string Put() //edit (U)
        {
            return "put called";
        }

        [HttpDelete]
        public string Delete() //(D)
        {
            return "delete called";
        }
    }
}
