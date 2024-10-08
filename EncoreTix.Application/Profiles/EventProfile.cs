using AutoMapper;
using EncoreTix.Core.Models;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

namespace EncoreTix.Application.Profiles;

public class EventProfile : Profile
{
    public EventProfile()
    {
        CreateMap<EventDto, Event>()
            .ForMember(s => s.Venues, opt => opt.MapFrom(d => d.Embedded.Venues))
            .ReverseMap();

        CreateMap<DatesDto, Dates>()
            .ReverseMap();

        CreateMap<VenueDto, Venue>()
            .ReverseMap();

        CreateMap<StartDateDto, StartDate>()
            .ReverseMap();

        CreateMap<DateStatusDto, DateStatus>()
            .ReverseMap();

        CreateMap<CityDto, City>()
            .ReverseMap();

        CreateMap<StateDto, State>()
            .ReverseMap();
    }
}
