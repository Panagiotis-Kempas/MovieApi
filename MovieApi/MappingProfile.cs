using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace MovieApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDto>();
        }
    }
}
