using AutoMapper;
using ApiModels = Wikipi.Domain.Models;
using RepoModels = Wikipi.Domain.Repository.Models;


namespace Wikipi.Domain.Mapper
{
    public class ProductMapper: Profile
    {
        public ProductMapper()
        {
            CreateMap<ApiModels.Product, RepoModels.Product>()
                .ForMember(x => x.Id, map => map.Ignore())
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));

            CreateMap<RepoModels.Product, ApiModels.Product>()
                .ForMember(x => x.Name, map => map.MapFrom(src => src.Name));
        }
    }
}
