using Chat_signalR.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat_signalR.Services
{
    public class GroupServices
    {
        private readonly ChatContextContext context;
        public GroupServices(ChatContextContext context)
        {
            this.context = context;
        }

        public async Task<List<Group>> GetAllGroups()
        {
            return await context.Groups.ToListAsync();
        }
    }
}
