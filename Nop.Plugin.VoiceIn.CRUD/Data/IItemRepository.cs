using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.VoiceIn.CRUD.Models;

namespace Nop.Plugin.VoiceIn.CRUD.Data
{
    public interface IItemRepository : IRepository<ItemModel>
    {
        // Define additional methods for CRUD operations or custom queries if needed
    }
}
