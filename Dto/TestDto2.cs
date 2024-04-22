using UIConfigGenerator.Attributes;

namespace DemoProject.Dto
{
    public class TestDto2
    {
        [DisplayName("Some description")]
        public string? Description1 { get; set; }
        public required string Description2 { get; set; }
    }
}
