using System.ComponentModel.DataAnnotations;

namespace Skill_tests_2.Dto
{
    public class CommentDto
    {
        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        public string Content { get; set; }

        [RegularExpression(@"^#[0-9a-f]{3,6}$", ErrorMessage = "Некорректный формат цвета")]
        public string BackColorHex { get; set; }
    }
}
