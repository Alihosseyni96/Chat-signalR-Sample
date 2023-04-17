using Chat_signalR.Models;
using Chat_signalR.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Chat_signalR.Services
{
    public class ChatServices
    {
        private readonly ChatContextContext _context;
        public ChatServices(ChatContextContext context)
        {
            _context = context;
        }


        public async Task<Group>  GetChatMessageByGroupId(int groupId)
        {
            var group =  await _context.Groups.Include(x=> x.Members).ThenInclude(x=> x.Messages).SingleAsync(x=> x.Id== groupId);

            return group;
        }

    }
}
