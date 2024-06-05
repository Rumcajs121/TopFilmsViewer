using AutoMapper;
using DomainLayer;

namespace ApplicationLayer;

public class DtoMappingProfile : Profile
{
    public DtoMappingProfile()
    {
        CreateMap<Movie, MainPageMovieDto>()
        .ForMember(dest => dest.MiniaturePhoto,
        opt => opt.MapFrom(src =>src.Photos.FirstOrDefault().Uri ))
        .ForMember(dest=>dest.Genre, opt=>opt.MapFrom(src=>src.Genres.Name))
        .ForMember(dest=>dest.Studio, opt=>opt.MapFrom(src=>src.Studios.StudioName));

        CreateMap<CreateMovieDto,Movie>();

        CreateMap<AddPhotosDto,Photo>(); 
    }
}