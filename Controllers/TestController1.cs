using DemoProject.Dto;
using Microsoft.AspNetCore.Mvc;
using UIConfigGenerator.Attributes;

namespace DemoProject.Controllers
{
    [ApiController]
    [AutoGenerateUI]
    [Route("api/controller1")]
    [DisplayName("My custom contoller")]
    public class TestController1 : ControllerBase
    {

        [HttpPost]
        [HttpPut]
        [Route("entity")]
        public void CreateEntity([FromBody] TestDto1 dto1)
        {
        }

        [HttpGet]
        [Route("entity")]
        [DisplayName("Retrieve entity")]
        public TestDto1 GetEntity(int id)
        {
            TestDto2 testDto2 = new() { Description1 = "Example description 1", Description2 = "Example description 2" };
            TestDto1 testDto1 = new() { Id = id, Flag = true, Status = TestEnum.SECOND, TextList = ["hi, hello"], CustomDate = "2024/05/25", TestDto2 = testDto2 };
            return testDto1;
        }
    }
}
