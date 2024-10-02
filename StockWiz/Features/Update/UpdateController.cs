using Microsoft.AspNetCore.Mvc;
using StockWiz.Features.Update.Services.Interfaces;
using StockWiz.Features.Common.Models;
using System.Threading.Tasks;

namespace StockWiz.Features.Update.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateController(IInventoryUpdateService inventoryUpdateService) : ControllerBase
    {
        // PUT: Update a general item by ID
        [HttpPut("item/{id}")]
        public async Task<IActionResult> UpdateItem(int id, [FromBody] Item item)
        {
            if (item == null || id != item.Id)
            {
                return BadRequest("Invalid item data.");
            }

            try
            {
                var updatedItem = await inventoryUpdateService.UpdateItemAsync(id, item);
                if (updatedItem == null)
                {
                    return NotFound($"Item with ID {id} not found.");
                }
                return Ok(updatedItem); // Returns 200 OK with the updated item
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: Update an electronic item by ID
        [HttpPut("electronic/{id}")]
        public async Task<IActionResult> UpdateElectronicItem(int id, [FromBody] ElectronicItem electronicItem)
        {
            if (electronicItem == null || id != electronicItem.Id)
            {
                return BadRequest("Invalid electronic item data.");
            }

            try
            {
                var updatedElectronicItem = await inventoryUpdateService.UpdateElectronicItemAsync(id, electronicItem);
                if (updatedElectronicItem == null)
                {
                    return NotFound($"Electronic item with ID {id} not found.");
                }
                return Ok(updatedElectronicItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // PUT: Update a grocery item by ID
        [HttpPut("grocery/{id}")]
        public async Task<IActionResult> UpdateGroceryItem(int id, [FromBody] GroceryItem groceryItem)
        {
            if (groceryItem == null || id != groceryItem.Id)
            {
                return BadRequest("Invalid grocery item data.");
            }

            try
            {
                var updatedGroceryItem = await inventoryUpdateService.UpdateGroceryItemAsync(id, groceryItem);
                if (updatedGroceryItem == null)
                {
                    return NotFound($"Grocery item with ID {id} not found.");
                }
                return Ok(updatedGroceryItem);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
