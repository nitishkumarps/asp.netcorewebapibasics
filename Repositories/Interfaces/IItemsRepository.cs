using Catalog.Entities;
namespace Catalog.Repositories.Interfaces
{
 public interface IItemsRepository
 {
  Item GetItem(Guid id);
  IEnumerable<Item> GetItems();
 }
}