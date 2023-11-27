using LetsChat.ActionResult;
using Microsoft.AspNetCore.Mvc;

namespace LetsChat.Controllers
{
    [Route("/api/{controller}")]
    [ApiController]
    public class HtmlController : ControllerBase
    {
        private readonly Func<string, HtmlResult> _htmlResult;
        public HtmlController(Func<string, HtmlResult> htmlResult)
        {
            _htmlResult = htmlResult;
        }

        [HttpGet]
        [Route("AllChatRooms")]
        public IActionResult WriteBlogs()
        {
            return _htmlResult(@"./wwwroot/html/ChatRoomsPage.html");
        }
    }
}