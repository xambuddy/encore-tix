using AutoMapper;
using EncoreTix.Core.Models;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

namespace EncoreTix.Application.Profiles;

public class AttractionProfile : Profile
{
    public AttractionProfile()
    {
        CreateMap<Attraction, AttractionDto>()
            .ReverseMap();
    }
}
