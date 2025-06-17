namespace PorfolioWeb.Dto
{
    public class AboutDto
    {
        public UserDto User { get; set; } = new();
        public List<ExperienceDto> Experiences { get; set; } = new();
    }
}
