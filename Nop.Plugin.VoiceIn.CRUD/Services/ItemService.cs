using System.Collections.Generic;
using Nop.Plugin.VoiceIn.CRUD.Data;
using Nop.Plugin.VoiceIn.CRUD.Models;

namespace Nop.Plugin.VoiceIn.CRUD.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ItemModel GetItemById(int itemId)
        {
            return _itemRepository.GetById(itemId);
        }

        public IList<ItemModel> GetAllItems()
        {
            return _itemRepository.GetAll();
        }

        public void CreateItem(ItemModel item)
        {
            _itemRepository.Insert(item);
        }

        public void UpdateItem(ItemModel item)
        {
            _itemRepository.Update(item);
        }

        public void DeleteItem(int itemId)
        {
            var item = _itemRepository.GetById(itemId);
            if (item != null)
            {
                _itemRepository.Delete(item);
            }
        }

        // Implement additional methods for other operations as needed
    }
}
