using Skill_tests_2.Dto;
using Skill_tests_2.Models;
using Profile = AutoMapper.Profile;

namespace Skill_tests_2.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Point, PointDto>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();
        }
    }
}
