using AutoMapper;
using EncoreTix.Application.Features.Events.Queries;
using EncoreTix.Core.Models;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Clients;
using MediatR;

namespace EncoreTix.Application.Features.Attractions;

public class GetEventsQueryHandler(IEventsClient eventsClient, IMapper mapper) : IRequestHandler<GetEventsQuery, IEnumerable<Event>>
{
    public async Task<IEnumerable<Event>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
    {
        var results = await eventsClient.SearchEvents(request.AttractionId, request.Keyword, request.Size, request.Page);

        return mapper.Map<IEnumerable<Event>>(results);
    }
}