using AutoMapper;
using Wikipi.Domain.Domain.Contracts;
using Wikipi.Domain.Repository.Interfaces;
using ApiModels = Wikipi.Domain.Models;
using RepoModels = Wikipi.Domain.Repository.Models;

namespace Wikipi.Domain.Domain
{
    public class UserHandler : IUserHandler
    {
        private readonly IBaseRepository _baseRepository;
        private readonly IMapper _mapper;
        public UserHandler(IBaseRepository baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }
        public async Task<ApiModels.User> CreateUser(ApiModels.User user)
        {
            var _repoUser = _mapper.Map<RepoModels.User>(user);
            _repoUser.CreatedDate = DateTime.Now;
            _repoUser.ModifiedDate = DateTime.Now;
            var newUser = await _baseRepository.Create<RepoModels.User>(_repoUser);
            return _mapper.Map<ApiModels.User>(newUser);
        }
    }
}
