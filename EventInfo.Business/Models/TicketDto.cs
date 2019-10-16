using System;
using System.Collections.Generic;
using System.Text;

namespace EventInfo.Business.Dtos
{
    public class TicketDto
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int EventId { get; set; }

    }
}
