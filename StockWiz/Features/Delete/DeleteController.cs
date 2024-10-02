using Microsoft.AspNetCore.Mvc;
using StockWiz.Features.Delete.Services.Interfaces;
using System.Threading.Tasks;

namespace StockWiz.Features.Delete.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeleteController(IInventoryDeleteService inventoryDeleteService) : ControllerBase
    {

        // DELETE: Delete a general item by ID
        [HttpDelete("item/{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            try
            {
                var result = await inventoryDeleteService.DeleteItemAsync(id);
                if (!result)
                {
                    return NotFound($"Item with ID {id} not found.");
                }
                return NoContent(); // 204 No Content response on successful deletion
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: Delete an electronic item by ID
        [HttpDelete("electronic/{id}")]
        public async Task<IActionResult> DeleteElectronicItem(int id)
        {
            try
            {
                var result = await inventoryDeleteService.DeleteElectronicItemAsync(id);
                if (!result)
                {
                    return NotFound($"Electronic item with ID {id} not found.");
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // DELETE: Delete a grocery item by ID
        [HttpDelete("grocery/{id}")]
        public async Task<IActionResult> DeleteGroceryItem(int id)
        {
            try
            {
                var result = await inventoryDeleteService.DeleteGroceryItemAsync(id);
                if (!result)
                {
                    return NotFound($"Grocery item with ID {id} not found.");
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
