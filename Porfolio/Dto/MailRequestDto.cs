using System.ComponentModel.DataAnnotations;

namespace PorfolioWeb.Dto
{
    public class MailRequestDto
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Your Email")]
        public string FromEmail { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Body { get; set; }
    }
}
