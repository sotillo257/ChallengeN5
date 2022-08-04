using Microsoft.AspNetCore.Mvc;
using N5.Core.Contracts;
using N5.Core.ModelsDto;
using Microsoft.Extensions.Logging;

namespace ChallengeN5.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PermissionTypeController : Controller
    {
        private readonly IPermissionTypeServices _service;
        private readonly ILogger<PermissionTypeController> _logger;

        public PermissionTypeController(ILogger<PermissionTypeController> logger, IPermissionTypeServices services) {
            _service = services;
            _logger = logger;
        }

        [HttpGet("GetAllPermissionTypesAsync")]
        public async Task<List<PermissionTypeDto>> GetAllPermissionTypesAsync() 
        {
            return await _service.GetAllPermissionTypesAsync(); 
        }
                


    }
}
