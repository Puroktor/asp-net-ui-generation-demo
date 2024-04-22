using DemoProject.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [ApiController]
    [Route("api/controller2")]
    public class TestController2 : ControllerBase
    {

        [HttpPost]
        public void IgnoredEdpoint(TestDto2 dto2)
        {
        }
    }
}
