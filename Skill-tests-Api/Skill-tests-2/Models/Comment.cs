using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Skill_tests_2.Models
{
    [Table("Comment")]
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        public string Content { get; set; }

        [RegularExpression(@"^#[0-9a-f]{3,6}$", ErrorMessage = "Некорректный формат цвета")]
        public string BackColorHex { get; set; }

        [Required]
        public int PointId { get; set; }
        [JsonIgnore]
        public Point Point { get; set; }
    }
}