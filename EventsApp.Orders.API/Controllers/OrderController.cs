using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderInfo.Business.Services;

namespace EventsApp.Orders.API.Controllers
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private ITicketOrderService _service;
        public OrderController(ITicketOrderService service)
        {
            _service = service;
        }
        [Route("events/{eventId}")]
        [HttpGet]
        public IActionResult GetOrders(int eventId)
        {
            var result= _service.GetOrders(eventId);
            return Ok(result);
        }

        [HttpGet("userId")]
        public IActionResult GetOrdersByUser(string userId)
        {
            var result = _service.GetOrdersByUser(userId);
            return Ok(result);
        }
    }
}