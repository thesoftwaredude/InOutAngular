using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace InOut.UI.SignalR
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello("message from the server");
        }
    }
}