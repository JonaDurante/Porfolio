using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Models
{
    public class TechnologyExperience
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }

        [Required]
        [StringLength(100)]
        public string Category { get; set; } = string.Empty;

        public List<string> Frameworks { get; set; } = new();

        public Experience Experience { get; set; }
    }
}