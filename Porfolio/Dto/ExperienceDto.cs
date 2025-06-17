namespace PorfolioWeb.Dto
{
    public class ExperienceDto
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Period { get; set; }
        public List<ResponsibilitiesDto> Responsibilities { get; set; } = new();
        public List<TechnologiesDto> Technologies { get; set; } = new();
    }
}
