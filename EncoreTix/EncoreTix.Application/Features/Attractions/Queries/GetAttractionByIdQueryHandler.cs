using AutoMapper;
using EncoreTix.Application.Features.Attractions.Queries;
using EncoreTix.Core.Models;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Clients;
using MediatR;

namespace EncoreTix.Application.Features.Attractions;

public class GetAttractionByIdQueryHandler(IAttractionsClient attractionsClient, IMapper mapper) : IRequestHandler<GetAttractionByIdQuery, Attraction>
{
    public async Task<Attraction> Handle(GetAttractionByIdQuery request, CancellationToken cancellationToken)
    {
        var attraction = await attractionsClient.GetAttractionDetails(request.Id);

        return mapper.Map<Attraction>(attraction);
    }
}