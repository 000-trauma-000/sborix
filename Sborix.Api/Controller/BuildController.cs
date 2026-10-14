using Entities.Catalog;
using Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Sborix.Application.DTO.Catalog;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuildController : ControllerBase
    {
        private readonly IBaseRepository<Build> _repository;

        public BuildController(IBaseRepository<Build> repository)
        {
            _repository = repository;
        }

        /// Получить список всех сборок.
        [HttpGet]
        public async Task<ActionResult<List<BuildDto>>> GetAll(CancellationToken cancellationToken)
        {
            var builds = await _repository.GetAllAsync(cancellationToken);

            var result = builds
                .Select(build => new BuildDto
                {
                    Id = build.Id,
                    Name = build.Name,
                    PricePerDay = build.PricePerDay
                })
                .ToList();

            return Ok(result);
        }

        /// Получить сборку по идентификатору.
        [HttpGet("{id}")]
        public async Task<ActionResult<BuildDto>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var foundBuild = await _repository.GetByIdAsync(id, cancellationToken);

            if (foundBuild is null)
            {
                return NotFound($"Объект с данным Id({id}) не найден.");
            }

            var result = new BuildDto
            {
                Id = foundBuild.Id,
                Name = foundBuild.Name,
                PricePerDay = foundBuild.PricePerDay
            };

            return Ok(result);
        }
    }
}