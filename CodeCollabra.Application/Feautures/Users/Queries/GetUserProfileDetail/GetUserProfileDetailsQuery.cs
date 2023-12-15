using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Application.Feautures.Users.Queries.GetUserProfileDetail
{
    public class GetUserProfileDetailsQuery : IRequest<GetUserProfileDetailsDTO>
    {
        public int id { get; set; }
    }
}
