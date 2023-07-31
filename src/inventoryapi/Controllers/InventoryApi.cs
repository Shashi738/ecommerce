using Microsoft.AspNetCore.Mvc;
using Application;
using Domain;

namespace inventoryapi.Controllers
{
    [ApiController]
    [Route("api/inventory")]
    public class InventoryApi : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryApi(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet("mobiles")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Mobile>>> GetPhonesAsync()
        {
            var mobiles = await _inventoryService.GetMobilesAsync();

            return Ok(mobiles);
        }
    }
}
