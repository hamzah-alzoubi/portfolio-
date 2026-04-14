using System.ComponentModel.DataAnnotations;

namespace portfoilo.Models
{
    public enum SkillsCategory
    {
        FrontEnd ,
        BackEnd,
        FullStack,
        Ai,
        Other
    }
    public class Skills
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public SkillsCategory Category { get; set; }
        [Required]
        public int Level { get; set; }


    }
}
