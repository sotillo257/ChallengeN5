using Microsoft.AspNetCore.Mvc;
using N5.Core.Contracts;
using N5.Core.ModelsDto;
using Microsoft.Extensions.Logging;

namespace ChallengeN5.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PermissionController : Controller
    {
        private readonly IPermissionServices _service;
        private readonly ILogger<PermissionController> _logger;

        public PermissionController(ILogger<PermissionController> logger, IPermissionServices services) {
            _service = services;
            _logger = logger;
        }

        [HttpGet("GetAllPermissionsAsync")]
        public async Task<PermissionResultDto> GetAllPermissionsAsync(int page = 0, int ItemsPerPage = 10) 
        {
            var permissionResult = new PermissionResultDto() { Page = page, ItemsPerPage = ItemsPerPage };
            return await _service.GetAllPermissionsAsync(permissionResult); 
        }

        [HttpPost("AddPermissionAsync")]
        public async Task<PermissionDto> AddPermissionAsync(PermissionAddDto permission)
        {
            return await _service.AddPermissionAsync(permission);            
        }

        [HttpPut("UpdatePermission")]
        public async Task<bool> UpdatePermission(PermissionUpdateDto permission)
        {
            var result = await _service.UpdatePermission(permission);
            return result;
        }


    }
}
