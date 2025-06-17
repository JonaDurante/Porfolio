using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Experience
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Company { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Period { get; set; } = string.Empty;

        public User User { get; set; }
        public List<Responsibility> Responsibilities { get; set; } = new();
        public List<TechnologyExperience> TechnologyExperiences { get; set; } = new();
    }
}
