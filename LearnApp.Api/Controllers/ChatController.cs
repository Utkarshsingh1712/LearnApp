using LearnApp.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnApp.Api.Controller
{
    [Route ("api/controller")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult > Post(UserInfo request)
        {

            return Ok();
        }
    }
}
