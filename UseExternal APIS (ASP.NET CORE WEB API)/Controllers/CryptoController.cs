using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UseExternal_APIS__ASP.NET_CORE_WEB_API_.Model;


namespace UseExternal_APIS__ASP.NET_CORE_WEB_API_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CryptoController : ControllerBase
    {
        private readonly CryptoService _service;

        public CryptoController(CryptoService service)
        {
            _service = service;
        }


        [HttpGet("live")]
        public async Task<IActionResult> Live()
        {
            var result = await _service.GetLiveCoinsAsync();
            return Ok(result);
        }


    }
}