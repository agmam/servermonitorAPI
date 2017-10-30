﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ServerDetailAverage
    {
       
            public int Id { get; set; }
            public Server Server { get; set; }
            public int ServerId { get; set; }
            public DateTime Created { get; set; }
            public decimal CPUUtilization { get; set; }
            public decimal RAMAvailable { get; set; }
            public decimal RAMTotal { get; set; }
            public decimal UpTime { get; set; }
            public decimal BytesReceived { get; set; }
            public decimal BytesSent { get; set; }
            public decimal Handles { get; set; }
            public decimal Processes { get; set; }
    }
}