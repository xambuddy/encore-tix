using EncoreTix.Application.Features.Events.Queries;
using EncoreTix.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace EncoreTix.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController(ILogger<EventsController> logger, IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<Event>> GetAttractions([FromQuery] string attractionId, [FromQuery][AllowNull] string? searchKeyword = null, [FromQuery][AllowNull] int size = 20, [FromQuery][AllowNull] int page = 0)
        {
            var query = new GetEventsQuery(attractionId, size, page, searchKeyword);

            return await mediator.Send(query);
        }
    }
}
