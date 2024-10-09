using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

namespace EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Clients;

public interface IEventsClient
{
    Task<IEnumerable<EventDto>> SearchEvents(string attractionId, string? keyword = null, int size = 20, int page = 0);
}
