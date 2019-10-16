using System;
using System.Collections.Generic;
using System.Text;

namespace OrderInfo.Business.Dtos
{
   public class OrderDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid UserId { get; set; }
        public int EventId { get; set; }
       
        public virtual UserDto User { get; set; }
        public virtual ICollection<TicketOrderDto> TicketOrder { get; set; }
    }
}
