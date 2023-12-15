using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class Badges : BaseEntity
    {
        public string BadgeName { get; set; }
        public string BadgeDescription { get; set; }
    }
}
