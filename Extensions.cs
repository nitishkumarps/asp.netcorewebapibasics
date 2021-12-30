using Catalog.Dtos;
using Catalog.Entities;

namespace Catalog
{
 public static class Extensions
 {
  public static ItemDto asDto(this Item item)
  {
   return new ItemDto
   {
    Id = item.Id,
    Price = item.Price,
    Name = item.Name,
    CreatedDate = item.CreatedDate
   };
  }
 }
}