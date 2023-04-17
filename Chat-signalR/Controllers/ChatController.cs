using Chat_signalR.Services;
using Microsoft.AspNetCore.Mvc;

namespace Chat_signalR.Controllers
{
    public class ChatController : Controller
    {
        private readonly ChatServices _service;
        public ChatController(ChatServices service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int groupId)
        {
            var res = await _service.GetChatMessageByGroupId(groupId);

            return View(res);
        }
    }
}
