using EncoreTix.Core.Models;

namespace EncoreTix.Application.Features.Attractions.Services;

public interface IAttractionsService
{
    Task<IEnumerable<Attraction>> GetAttractions(string? keyword = null, int size = 20, int page = 0);

    Task<Attraction> GetAttraction(string id);
}
