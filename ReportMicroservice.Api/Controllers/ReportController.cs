using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportMicroservice.Api.Services;
using ReportMicroservice.Domain.Entities;
using ReportMicroservice.Domain.InterfacesServices;

namespace ReportMicroservice.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IOpTransporteTerrestreService _opTransporteTerrestreService;

        public ReportController(IOpTransporteTerrestreService opTransporteTerrestreService) {
            _opTransporteTerrestreService = opTransporteTerrestreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _opTransporteTerrestreService.GetAllAsync();
            return Ok(result);
        }
    }
}
