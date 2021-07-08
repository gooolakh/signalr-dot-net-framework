using System;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace sslwebapp
{
    public class ChatHub : Hub
    {
        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}