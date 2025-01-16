using Wikipi.Domain.Models;

namespace Wikipi.Domain.Domain.Contracts
{
    public interface IProductsHandler
    {
        Task<Product> Create(Product product);
    }
}
