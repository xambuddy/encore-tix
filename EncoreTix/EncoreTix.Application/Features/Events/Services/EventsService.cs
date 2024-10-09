using EncoreTix.Application.Features.Events.Queries;
using EncoreTix.Core.Models;
using MediatR;

namespace EncoreTix.Application.Features.Events.Services;

public class EventsService(IMediator mediator) : IEventsService
{
    public async Task<IEnumerable<Event>> GetEvents(string attractionId, string? keyword = null, int size = 20, int page = 0)
    {
        return await mediator.Send(new GetEventsQuery(attractionId, size, page, keyword));
    }
}
