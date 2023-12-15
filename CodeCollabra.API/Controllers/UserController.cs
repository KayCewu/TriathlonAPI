using CodeCollabra.Application.Feautures.Users.Queries.GetUserProfileDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace CodeCollabra.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("UserProfileDetails/{id}")]
        public async Task<ActionResult<GetUserProfileDetailsDTO>> GetUserProfileDetails(int id)
        {
            var userProfileDetails = await _mediator.Send(new GetUserProfileDetailsQuery { id = id });
            return Ok(userProfileDetails);
        }

        
    }
}
