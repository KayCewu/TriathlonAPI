using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class Points : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int PointValue { get; set; }
    }
}
