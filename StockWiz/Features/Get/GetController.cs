using Microsoft.AspNetCore.Mvc;
using StockWiz.Features.Get.Services.Interfaces;

namespace StockWiz.Features.Get;

[ApiController]
[Route("[controller]")]
public class GetController(IInventoryGetService inventoryGetService, ILogger<GetController> logger) : ControllerBase
{
    // GET: Retrieve all items
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
        if (item == null)
        {
            return NotFound($"Item with ID {id} not found.");
        }
        return Ok(item);
    }

    // GET: Retrieve all grocery items
    [HttpGet("grocery-items")]
    public async Task<IActionResult> GroceryItems()
    {
        var groceryItems = await inventoryGetService.GetGroceryItems();
        return Ok(groceryItems);
    }

    // GET: Retrieve a specific grocery item by ID
    [HttpGet("grocery-item/{id}")]
    public async Task<IActionResult> GroceryItemById(int id)
    {
        var groceryItem = await inventoryGetService.GetGroceryItemById(id);
        if (groceryItem == null)
        {
            return NotFound($"Grocery item with ID {id} not found.");
        }
        return Ok(groceryItem);
    }

    // GET: Retrieve all electronic items
    [HttpGet("electronic-items")]
    public async Task<IActionResult> ElectronicItems()
    {
        var electronicItems = await inventoryGetService.GetElectronicItems();
        return Ok(electronicItems);
    }

    // GET: Retrieve a specific electronic item by ID
    [HttpGet("electronic-item/{id}")]
    public async Task<IActionResult> ElectronicItemById(int id)
    {
        var electronicItem = await inventoryGetService.GetElectronicItemById(id);
        if (electronicItem == null)
        {
            return NotFound($"Electronic item with ID {id} not found.");
        }
        return Ok(electronicItem);
    }
}
