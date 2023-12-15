using CodeCollabra.Application.Repositories;
using CodeCollabra.Domain;
using CodeCollabra.Infrastructure.DatabaseContext;

namespace CodeCollabra.Infrastructure.Repositories
{
    public class AchievementsRepository : GenericRepository<Achievements>, IAchievementsRepository
    {
        public AchievementsRepository(CodeCollabraDBContext context) : base(context)
        {

        }
    }
}
