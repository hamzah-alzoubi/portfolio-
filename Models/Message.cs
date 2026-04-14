using System.ComponentModel.DataAnnotations;

namespace portfoilo.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string SenderName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Invalid Form !!!")]
        public string EmailAddress { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 25, ErrorMessage = "Message must be between 25 and 500 characters.")]
        public string Body { get; set; }
        public DateTime ReceivedAt { get; set; } 
    }
}
