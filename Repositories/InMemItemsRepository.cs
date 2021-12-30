using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories.Interfaces;
namespace Catalog.Repositories
{


 public class InMemItemsRepository : IItemsRepository
 {
  private readonly List<Item> items = new()
  {
   new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
   new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 25, CreatedDate = DateTimeOffset.UtcNow },
   new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 30, CreatedDate = DateTimeOffset.UtcNow },
  };

  public IEnumerable<Item> GetItems()
  {
   return items;
  }
  public Item GetItem(Guid id)
  {
   return items.FirstOrDefault(item => item.Id == id);
  }
 }
}