using EncoreTix.Application.Features.Attractions.Queries;
using EncoreTix.Core.Models;
using MediatR;

namespace EncoreTix.Application.Features.Attractions.Services;

public class AttractionsService(IMediator mediator) : IAttractionsService
{
    public async Task<Attraction> GetAttraction(string id)
    {
        return await mediator.Send(new GetAttractionByIdQuery(id));
    }

    public async Task<IEnumerable<Attraction>> GetAttractions(string? keyword = null, int size = 20, int page = 0)
    {
        return await mediator.Send(new GetAttractionsQuery(size, page, keyword));
    }
}
