﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CorePdf.Models
{
    public class TicketModel
    {
        [Key]
        public Guid GUID{ get; set; } 

        public string Name { get; set; }
    }
}
