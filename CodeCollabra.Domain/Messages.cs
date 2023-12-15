using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class Messages : BaseEntity
    {
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
