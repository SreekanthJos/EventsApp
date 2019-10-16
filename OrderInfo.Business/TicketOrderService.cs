using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventInfo.Data;
using EventInfo.Data.Entities;
using OrderInfo.Business.Dtos;
using Remotion.Linq.Clauses;

namespace OrderInfo.Business.Services
{
    public class TicketOrderService: ITicketOrderService
    {
        private EventsDBContext _dbContext;
        private IAutoMapper _mapper;
        public TicketOrderService(EventsDBContext dbContext, IAutoMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<OrderDto> GetOrders(int eventId)
        {
            var orders= _dbContext.Order.Where(p => p.EventId == eventId);
            return _mapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(orders).ToList();
        }

        public List<TicketOrderDto> GetOrdersByUser(string userId)
        {
            var ticketOrders = from tc in _dbContext.TicketOrder
                join ord in _dbContext.Order on tc.OrderId equals ord.Id
                where ord.UserId.ToString() == userId
                select tc;
                               
            return _mapper.Map<IEnumerable<TicketOrder>, IEnumerable<TicketOrderDto>>(ticketOrders).ToList();
        } 
        public string OrderTickets(int eventId, List<string> ticketIds)
        {
            return "";
        }


    }
}
