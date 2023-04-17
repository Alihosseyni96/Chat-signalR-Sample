using Chat_signalR.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat_signalR.Hubs
{
    public class ChatHub :Hub
    {
        private readonly ChatContextContext _context;
        public ChatHub(ChatContextContext context)
        {
            _context = context;
        }

        // when connect signalR for first time
        public override Task OnConnectedAsync()
        {
            Clients.Caller.SendAsync("Welcome", 25);
            return base.OnConnectedAsync();
        }

        // when signlalR will be disconnected
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            return base.OnDisconnectedAsync(exception);
        }


        public async Task CreateNewMessage(int memberId , string text)
        {
            var message = new Message()
            {
                Text = text,
                MemberId = memberId
            };
            _context.Messages.Add(message);
            _context.SaveChanges();

            await Clients.Caller.SendAsync("ReceiveMessage", message);
        }
    }
}
