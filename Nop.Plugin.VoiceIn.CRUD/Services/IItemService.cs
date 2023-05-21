using System.Collections.Generic;
using Nop.Plugin.VoiceIn.CRUD.Models;

namespace Nop.Plugin.VoiceIn.CRUD.Services
{
    public interface IItemService
    {
        ItemModel GetItemById(int itemId);
        IList<ItemModel> GetAllItems();
        void CreateItem(ItemModel item);
        void UpdateItem(ItemModel item);
        void DeleteItem(int itemId);
    }
}
