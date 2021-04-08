using ChatMVC.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMVC.Hubs
{
    public class OrderHub : Hub
    {
        private IHubContext<OrderHub> _hub;
        private Dictionary<string, string> _connList;
        public OrderHub(IHubContext<OrderHub> hub)
        {
            _hub = hub;
            _connList = new Dictionary<string, string>();
        }
        public string GetConnectionId()
        {
            var connId = Context.ConnectionId;
            //if (!_connList.ContainsKey("pizozo"))
            //    _connList.Add("pizozo",connId);
            return connId;
        }

        public async Task SendMessage(Order order, string connectionId)
        {
            await Clients.All.SendAsync("ReceiveMessage", order);
        }

        public async Task NewMessage(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}
