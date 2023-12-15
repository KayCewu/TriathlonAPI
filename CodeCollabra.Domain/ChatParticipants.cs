using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class ChatParticipants : BaseEntity
    {
        public Chat Chat { get; set; }
        public User User { get; set; }
        public string Role { get; set; }
    }
}
