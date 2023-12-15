using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class ChatParticipantBadges : BaseEntity
    {
        public int ChatParticiPantId { get; set; }
        public ChatParticipants Participant { get; set; }
        public int BadgeId { get; set; }
        public Badges Badges { get; set; }
    }
}
