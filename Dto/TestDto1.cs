﻿using UIConfigGenerator.Attributes;

namespace DemoProject.Dto
{
    public class TestDto1
    {
        [DisplayName("ID description")]
        [NumberField(Min = 0, Max = int.MaxValue)]
        public int Id { get; set; }
        public TestEnum? Status { get; set; }
        public required List<string> TextList { get; set; }
        [DisplayName("Flag description")]
        public required bool Flag { get; set; }
        [DisplayName("Custom Date")]
        [DateField("yyyy/MM/dd")]
        public required string CustomDate { get; set; }
        [DisplayName("Inner DTO")]
        public required TestDto2 TestDto2 { get; set; }
    }
}
