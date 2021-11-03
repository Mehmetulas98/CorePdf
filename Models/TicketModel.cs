using System;
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
        public string LastName { get; set; }

        public string SeatNo { get; set; }

        public string Email { get; set; }
        public string Destination { get; set; }

        public string Departure { get; set; }

        public string Gate { get; set; }

        public DateTime DestinationTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public string FlightNumber { get; set; }

        public string Class { get; set; }
        public string FQTV { get; set; }

        public string GroupCode { get; set; }

    }
}
