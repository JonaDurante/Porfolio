namespace PorfolioWeb.Dto
{
    public class SkillDto
    {
        public List<ResponsibilitiesDto> Responsibilities { get; set; }
        public List <TechnologiesDto> Technologies { get; set; } = new List<TechnologiesDto>();

    }
}
