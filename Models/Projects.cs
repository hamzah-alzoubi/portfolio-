using System.ComponentModel.DataAnnotations;

namespace portfoilo.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string TechUsed { get; set; }

        public string? GitHubLink { get; set; }
        public string? LiveDemoLink { get; set; }



    }
}
