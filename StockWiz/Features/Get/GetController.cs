using Microsoft.AspNetCore.Mvc;
using StockWiz.Features.Common.Models;
using StockWiz.Features.Get.Services.Interfaces;

namespace StockWiz.Features.Get
{
    [ApiController]
    [Route("[controller]")]
    public class GetController(IInventoryGetService inventoryGetService, ILogger<GetController> logger) : ControllerBase
    {

        [HttpGet("items")]
        public async Task<IActionResult> Items()
        {
            var items = await inventoryGetService.GetAllItems();

            return Ok(items);
        }

        // GET: Retrieve a specific item by ID
        [HttpGet("item/{id}")]
        public async Task<IActionResult> ItemById(int id)
        {
            var item = await inventoryGetService.GetItemById(id);
            return Ok(item);
        }

    }
}
