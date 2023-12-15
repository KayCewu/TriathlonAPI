using CodeCollabra.Application.Repositories;
using CodeCollabra.Domain;
using CodeCollabra.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.IdentityModel.Tokens;

namespace CodeCollabra.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGenericRepository<User> _repo;
        public UserController(IGenericRepository<User> repo)
        {
                _repo = repo;
        }
        [HttpGet("GetUsers")]
        public IEnumerable<User> GetAllUsers()
        {
            var Users= _repo.GetAllAsync().Result;
            if (!Users.IsNullOrEmpty())
            {
                return Users.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
