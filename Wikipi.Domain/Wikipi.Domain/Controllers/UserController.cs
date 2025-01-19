using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wikipi.Domain.Domain.Contracts;
using Wikipi.Domain.Models;

namespace Wikipi.Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserHandler _userHandler;
        public UserController(IUserHandler userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesErrorResponseType(typeof(Exception))]
        public async Task<User> Create(User user)
        {
            var createdUser = await _userHandler.CreateUser(user);
            return createdUser;
        }
    }
}
