using Catalog.Repositories;
using Catalog.Repositories.Interfaces;
using Catalog.Entities;
using Microsoft.AspNetCore.Mvc;
using Catalog.Dtos;

namespace Catalog.Controllers
{

 [ApiController]
 [Route("api/[controller]/[action]")]
 public class ItemsController : ControllerBase
 {
  private readonly IItemsRepository repository;

  public ItemsController(IItemsRepository repository)
  {
   this.repository = repository;
  }

  [HttpGet]
  public IEnumerable<ItemDto> GetItems()
  {
   var items = repository.GetItems().Select(item => item.asDto());
   return items;
  }

  [HttpGet]
  public ActionResult<ItemDto> GetItem(Guid id)
  {
   var item = repository.GetItem(id).asDto();
   if (item is null)
   {
    return NotFound();
   }
   return Ok(item);
  }
 }
}