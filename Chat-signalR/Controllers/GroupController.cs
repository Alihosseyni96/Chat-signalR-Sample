using Chat_signalR.Models;
using Chat_signalR.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Chat_signalR.Controllers
{
    public class GroupController : Controller
    {
        private readonly GroupServices _services;
        public GroupController(GroupServices services)
        {
            _services= services;
        }
        public async Task<IActionResult> AllGroups()
        {
            var groups = await _services.GetAllGroups();
            return View(groups);
        }
    }
}
