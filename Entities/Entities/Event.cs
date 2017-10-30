﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public Server Server { get; set; }
        public int ServerId { get; set; }
        public EventType EventType { get; set; }
        public int EventTypeId { get; set; }
        public ServerDetail ServerDetail { get; set; }
        public int ServerDetailId { get; set; }


    }

    
}