using Wikipi.Domain.Models;
using ApiModels = Wikipi.Domain.Models;

namespace Wikipi.Domain.Domain.Contracts
{
    public interface IUserHandler
    {
        Task<ApiModels.User> CreateUser(ApiModels.User user);
    }
}
