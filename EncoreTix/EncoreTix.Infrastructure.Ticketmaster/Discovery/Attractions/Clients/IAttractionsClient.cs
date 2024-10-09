using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Clients;

public interface IAttractionsClient
{
    Task<IEnumerable<AttractionDto>> SearchAttractions(string? keyword = null, int size = 20, int page = 0);
}
