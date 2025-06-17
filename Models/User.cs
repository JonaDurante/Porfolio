using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Range(0, 120)]
        public int Age { get; set; }

        [StringLength(100)]
        public string Country { get; set; } = string.Empty;

        [StringLength(100)]
        public string City { get; set; } = string.Empty;

        public List<Experience> Experiences { get; set; } = new();
    }
}
