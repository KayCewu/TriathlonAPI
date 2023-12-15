using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class Achievements : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string AchievementName { get; set; }
        public string Description { get; set; }
    }
}
