using EncoreTix.Application.Features.Attractions.Queries;
using EncoreTix.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace EncoreTix.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttractionsController(ILogger<AttractionsController> logger, IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Attraction>> GetAttractions([FromQuery][AllowNull] string? searchKeyword = null, [FromQuery][AllowNull] int size = 20, [FromQuery][AllowNull] int page = 0)
        {
            var query = new GetAttractionsQuery(size, page, searchKeyword);

            return await mediator.Send(query);
        }
    }
}
