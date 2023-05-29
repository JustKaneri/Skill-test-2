using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Skill_tests_2.Dto;
using Skill_tests_2.Interface;
using Skill_tests_2.Models;
using Skill_tests_2.Repository;

namespace Skill_tests_2.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class PointController : Controller
    {
        private readonly IRepositoryPoint<Point> _repository;
        private readonly IMapper _mapper;

        public PointController(IRepositoryPoint<Point> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("points")]
        public async Task<IActionResult> GetAllPoint()
        {
            var result = await _repository.GetAll();

            if (result.Count() == 0)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("point/{id}")]
        public async Task<IActionResult> RemovePoint(int id)
        {
            var result = await _repository.Delete(id);

            if (result == null)
                return BadRequest("Не удалось удалить точку");

            return Ok(result);
        }

        [HttpPost("point")]
        public async Task<IActionResult> CratePoint(PointDto enity)
        {
            Point point = _mapper.Map<Point>(enity);

            if (point.Radius < 0 || point.Radius == 0)
                return BadRequest("Радиус должен быть больше 0");

            var result = await _repository.Create(point);

            if (result == null)
                return BadRequest("Не удалось cоздать точку");

            return Ok(result);
        }
    }
}
