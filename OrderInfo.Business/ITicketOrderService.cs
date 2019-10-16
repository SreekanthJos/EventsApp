using System;
using System.Collections.Generic;
using System.Text;
using OrderInfo.Business.Dtos;

namespace OrderInfo.Business.Services
{
    public interface ITicketOrderService
    {
        List<OrderDto> GetOrders(int eventId);
        List<TicketOrderDto> GetOrdersByUser(string userId);
        string OrderTickets(int eventId,List<string> ticketIds);


    }
}
