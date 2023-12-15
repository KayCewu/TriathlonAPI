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
    public class PointsRepository : GenericRepository<Points>, IPointsRepository
    {
        public PointsRepository(CodeCollabraDBContext context) : base(context)
        {

        }
    }
}
