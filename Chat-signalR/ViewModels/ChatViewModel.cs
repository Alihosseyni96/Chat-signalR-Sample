using Chat_signalR.Models;

namespace Chat_signalR.ViewModels
{
    public class ChatViewModel
    {
        public Group Group { get; set; }
        public List<Message> Messages { get; set; }
        public List<Member> Members { get; set; }
    }
}
