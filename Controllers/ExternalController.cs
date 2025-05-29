using Microsoft.AspNetCore.Mvc;
using TesteBackend.ExternalApi.Services;

namespace TesteBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternalController : ControllerBase
    {
        private readonly PlaceholderService _placeholderService;

        public ExternalController(PlaceholderService placeholderService)
        {
            _placeholderService = placeholderService;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetExternalUsers()
        {
            var json = await _placeholderService.GetExternalUsersAsync();
            return Content(json, "application/json");
        }
    }
}
