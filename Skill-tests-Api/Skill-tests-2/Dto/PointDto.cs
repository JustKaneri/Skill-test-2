using System.ComponentModel.DataAnnotations;

namespace Skill_tests_2.Dto
{
    public class PointDto
    {
        [Required]
        public int Xcoordinate { get; set; }

        [Required]
        public int Ycoordinate { get; set; }

        [Required]
        public int Radius { get; set; }

        [RegularExpression(@"^#[0-9a-f]{3,6}$", ErrorMessage = "Некорректный формат цвета")]
        public string ColorHex { get; set; }
    }
}
