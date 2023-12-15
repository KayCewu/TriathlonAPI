using CodeCollabra.Application.Repositories;
using CodeCollabra.Domain;
using CodeCollabra.Infrastructure.DatabaseContext;

namespace CodeCollabra.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CodeCollabraDBContext context) : base(context)
        {

        }

    }
}
