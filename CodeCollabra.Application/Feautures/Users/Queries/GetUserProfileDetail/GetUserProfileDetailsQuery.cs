using MediatR;

namespace CodeCollabra.Application.Feautures.Users.Queries.GetUserProfileDetail
{
    public class GetUserProfileDetailsQuery : IRequest<GetUserProfileDetailsDTO>
    {
        public int id { get; set; }
    }
}
