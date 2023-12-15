using CodeCollabra.Application.Exceptions;
using CodeCollabra.Application.Repositories;
using MediatR;

namespace CodeCollabra.Application.Feautures.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<GetAllUsersDTO>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<GetAllUsersDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var getAllusers = await _userRepository.GetAllAsync();
                List<GetAllUsersDTO> allUsers = new List<GetAllUsersDTO>();

                foreach (var user in getAllusers)
                {
                    allUsers.Add(new GetAllUsersDTO
                    {
                        UserId = user.Id,
                        Email = user.Email,
                        UserName = user.Username
                    });
                }

                return allUsers;
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Could not find any users.");
            }
        }
    }
}
