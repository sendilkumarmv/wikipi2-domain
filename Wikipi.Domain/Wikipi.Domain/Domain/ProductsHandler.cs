using AutoMapper;
using Wikipi.Domain.Domain.Contracts;
using Wikipi.Domain.Models;
using Wikipi.Domain.Repository.Interfaces;
using RepoModels = Wikipi.Domain.Repository.Models;
using ApiModels = Wikipi.Domain.Models;

namespace Wikipi.Domain.Domain
{
    public class ProductsHandler: IProductsHandler
    {
        private readonly IBaseRepository _repository;
        private readonly IMapper _mapper;
        public ProductsHandler(IMapper mapper, IBaseRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Product> Create(Product product)
        {
            var repoProduct = _mapper.Map<RepoModels.Product>(product);
            repoProduct.CreatedDate = DateTime.Now;
            repoProduct.ModifiedDate = DateTime.Now;
            var newProduct  = await _repository.Create<RepoModels.Product>(repoProduct);
            return _mapper.Map<ApiModels.Product>(newProduct);
        }
    }
}
