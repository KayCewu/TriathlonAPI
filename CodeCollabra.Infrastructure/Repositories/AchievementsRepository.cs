using CodeCollabra.Application.Repositories;
using CodeCollabra.Domain;
using CodeCollabra.Infrastructure.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Infrastructure.Repositories
{
    public class AchievementsRepository : GenericRepository<Achievements>, IAchievementsRepository
    {
        public AchievementsRepository(CodeCollabraDBContext context) : base(context)
        {

        }
    }
}
