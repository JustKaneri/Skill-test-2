using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Skill_tests_2.Dto;
using Skill_tests_2.Interface;
using Skill_tests_2.Models;

namespace Skill_tests_2.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class CommentController : Controller
    {
        private readonly IRepositoryComment<Comment> _repository;
        private readonly IMapper _mapper;

        public CommentController(IRepositoryComment<Comment> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet("point/{id}/comments")]
        public async Task<IActionResult> GetComments(int id)
        {
            var comment = await _repository.GetCommentCurrentPoint(id);

            if (comment.Count() == 0)
                return NotFound();

            return Ok(comment);
        }

        [HttpDelete("comment/{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var result = await _repository.Delete(id);

            if (result == null)
                return BadRequest("Не удалость удалить коментарий");

            return Ok(result);
        }

        [HttpPost("point/{id}/comment")]
        public async Task<IActionResult> CreateComment(CommentDto comment,int id)
        {
            Comment enity = _mapper.Map<Comment>(comment);

            enity.PointId = id;

            var result = await _repository.Create(enity);

            if (result == null)
                return BadRequest("Не удалость создать коментарий");

            return Ok(result);
        }
    }
}
