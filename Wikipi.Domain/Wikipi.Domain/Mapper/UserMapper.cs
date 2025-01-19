using AutoMapper;
using ApiModels = Wikipi.Domain.Models;
using RepoModels = Wikipi.Domain.Repository.Models;

namespace Wikipi.Domain.Mapper
{
    public class UserMapper: Profile
    {
        public UserMapper()
        {
            CreateMap<ApiModels.User, RepoModels.User>()
                .ForMember(dest => dest.Id, map => map.Ignore())
                .ForMember(dest => dest.FirstName, map => map.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, map => map.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, map => map.MapFrom(src => src.Email));

            CreateMap<RepoModels.User, ApiModels.User>()
                .ForMember(dest => dest.FirstName, map => map.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, map => map.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Email, map => map.MapFrom(src => src.Email));

        }
    }
}
