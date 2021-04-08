using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatMVC.Data;
using ChatMVC.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChatMVC.Controllers.API
{
    [Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IHubContext<OrderHub> _hub;
        private ApplicationDbContext _db;
        public OrderController(IHubContext<OrderHub> hub)
        {
            _hub = hub;
        }

    }
}
