using System.ComponentModel.DataAnnotations;

namespace DairyApp.Models
{
    public class DairyEntry
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
