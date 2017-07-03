using Microsoft.AspNet.SignalR;

namespace PerfSurf.Hubs
{
    public class PefHub : Hub
    {
        public void SendMessage(string message)
        { 
            Clients.All.NewMessage(Context.User.Identity.Name + " says: " + message);
        }
    }
}