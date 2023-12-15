using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class ActivityHistory : BaseEntity
    {
        public User User { get; set; }
        public string ActivityType { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
