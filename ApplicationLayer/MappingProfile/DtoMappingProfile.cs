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
<<<<<<< HEAD

        CreateMap<CreateMovieDto,Movie>();

        CreateMap<AddPhotosDto,Photo>(); 
        CreateMap<AddGenreDto,Genre>();
        CreateMap<AddStudioDto,Studio>();
=======
>>>>>>> parent of 7de393d (feat(Dto/AddPhotoMethod) I created one method with add new photo in the feature i propably use blob storage for save all photo and must refactoring this code . this method return string Uri for link and was use transaction for my database)
    }
}