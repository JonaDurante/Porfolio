using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Responsibility
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Category { get; set; }

        public Experience Experience { get; set; }
    }
}
