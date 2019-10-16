using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;

namespace EventInfo.Business.Dtos
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Venue { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public int? AvailableTickets => Ticket?.Count;

        public List<TicketDto> Ticket { get; set; }
    }
}
