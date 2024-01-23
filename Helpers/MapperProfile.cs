using AutoMapper;
using Examen.Models.Dog;
using Examen.Models.Dog.Dto;

namespace Examen.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Dog, DogDto>();
            CreateMap<DogDto, Dog>();
        }
    }
}
