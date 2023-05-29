using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Skill_tests_2.Models
{
    [Table("Point")]
    public class Point
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Xcoordinate { get; set; }

        [Required]
        public int Ycoordinate { get; set; }

        [Required]
        public int Radius { get; set; }

        [RegularExpression(@"^#[0-9a-f]{3,6}$", ErrorMessage ="Некорректный формат цвета")]
        public string ColorHex { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
