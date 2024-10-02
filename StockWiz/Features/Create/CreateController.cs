using Microsoft.AspNetCore.Mvc;
using StockWiz.Features.Create.Services.Interfaces;
using StockWiz.Features.Common.Models;

namespace StockWiz.Features.Create.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateController(IInventoryCreateService inventoryCreateService) : ControllerBase
    {

        // POST: Create a general item in the inventory
        [HttpPost("item")]
        public async Task<IActionResult> CreateItem([FromBody] Item item)
        {
            if (item == null)
            {
                return BadRequest("Item is null.");
            }

            try
            {
                var newItem = await inventoryCreateService.CreateItemAsync(item);
                return Created("", newItem);  // Returns 201 Created response
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: Create an electronic item in the inventory
        [HttpPost("electronic")]
        public async Task<IActionResult> CreateElectronicItem([FromBody] ElectronicItem electronicItem)
        {
            if (electronicItem == null)
            {
                return BadRequest("Electronic item is null.");
            }

            try
            {
                var newElectronicItem = await inventoryCreateService.CreateElectronicItemAsync(electronicItem);
                return Created("", newElectronicItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // POST: Create a grocery item in the inventory
        [HttpPost("grocery")]
        public async Task<IActionResult> CreateGroceryItem([FromBody] GroceryItem groceryItem)
        {
            if (groceryItem == null)
            {
                return BadRequest("Grocery item is null.");
            }

            try
            {
                var newGroceryItem = await inventoryCreateService.CreateGroceryItemAsync(groceryItem);
                return Created("", newGroceryItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
