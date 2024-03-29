﻿using CodeCollabra.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCollabra.Domain
{
    public class ChatGptSessions : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Context { get; set; }
        public DateTime LastInteractionTime { get; set; }
    }
}
