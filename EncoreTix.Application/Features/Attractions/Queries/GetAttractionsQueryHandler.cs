using AutoMapper;
using EncoreTix.Application.Features.Attractions.Queries;
using EncoreTix.Core.Models;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Services;
using MediatR;

namespace EncoreTix.Application.Features.Attractions;

public class GetAttractionsQueryHandler(IAttractionsService attractionsService, IMapper mapper) : IRequestHandler<GetAttractionsQuery, IEnumerable<Attraction>>
{
    public async Task<IEnumerable<Attraction>> Handle(GetAttractionsQuery request, CancellationToken cancellationToken)
    {
        var results = await attractionsService.SearchAttractions(request.Keyword, request.Size, request.Page);

        return mapper.Map<IEnumerable<Attraction>>(results);
    }
}