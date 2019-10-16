using System;

namespace OrderInfo.Business.Dtos
{
    public class TicketOrderDto
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid TicketId { get; set; }
        public int Quantity { get; set; }
        public int EventId { get; set; }
        public virtual OrderDto Order { get; set; }
     
    }
}
