using AutoMapper;
using EncoreTix.Core.Models;
using EncoreTix.Infrastructure.Ticketmaster.Discovery.Attractions.Models;

namespace EncoreTix.Application.Profiles;

public class AttractionProfile : Profile
{
    public AttractionProfile()
    {
        CreateMap<AttractionDto, Attraction>()
            .ReverseMap();

        CreateMap<ImageDto, Image>()
            .ReverseMap();

        CreateMap<ExternalLinksDto, ExternalLinks>()
            .ReverseMap();

        CreateMap<ExternalLinkDto, ExternalLink>()
            .ReverseMap();
    }
}
