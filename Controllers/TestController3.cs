using Microsoft.AspNetCore.Mvc;
using UIConfigGenerator.Attributes;

namespace DemoProject.Controllers
{
    [ApiController]
    [AutoGenerateUI]
    [Route("api/controller3")]
    public class TestController3 : ControllerBase
    {

        [HttpPost("example/{id}")]
        [DisplayName("Another example method")]
        public void DeleteEntity([FromRoute(Name = "id")][DisplayName("First ID")] int id1,
                                 [FromQuery(Name = "ID2")] int id2)
        {
        }
    }
}
